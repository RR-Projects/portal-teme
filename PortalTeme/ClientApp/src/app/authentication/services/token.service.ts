import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { AntiforgeryService } from './antiforgery.service';
import { ReplaySubject, Observable, of } from 'rxjs';
import { flatMap, take } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  constructor(private http: HttpClient, private antiforgery: AntiforgeryService) { }

  private jwt: JwtHelperService = new JwtHelperService();
  private cachedAccessToken: ReplaySubject<string> = null;

  public getAccessToken(refresh: boolean = false): Observable<string> {
    if (!refresh && this.cachedAccessToken)
      return this.cachedAccessToken
        .pipe(flatMap((accessToken) => this.validateToken(accessToken)));

    this.cachedAccessToken = this.cachedAccessToken || new ReplaySubject<string>(1);

    this.requestToken();

    return this.cachedAccessToken;
  }

  private validateToken(accessToken: string) {
    if (!accessToken || this.jwt.isTokenExpired(accessToken))
      return this.getAccessToken(true);

    return of(accessToken);
  }

  private requestToken() {

    const antiforgeryToken = this.antiforgery.getAntiforgeryToken();

    let headers = {};
    headers[this.antiforgery.getHeaderName()] = antiforgeryToken;

    this.http.get('/authentication/token', {
      observe: 'response',
      headers: new HttpHeaders(headers)
    }).pipe(take(1))
      .subscribe(response => {
        let accessToken = response.headers.get('AccessToken') || null;
        if (accessToken == null || this.jwt.isTokenExpired(accessToken))
          accessToken = null;

        this.cachedAccessToken.next(accessToken);
      });
  }
}
