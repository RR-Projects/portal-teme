import { Pipe, PipeTransform, SecurityContext } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';

@Pipe({ name: 'safeHtml', pure: true })
export class SafeHtmlPipe implements PipeTransform {
    constructor(private sanitizer: DomSanitizer) { }

    transform(value, args: string[]): SafeHtml {
        return this.sanitizer.bypassSecurityTrustHtml(value);
    }
}