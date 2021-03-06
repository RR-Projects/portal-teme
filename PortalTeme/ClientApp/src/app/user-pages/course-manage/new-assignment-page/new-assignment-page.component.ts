import { Component, OnInit, OnDestroy } from '@angular/core';

import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ModelServiceFactory } from '../../../services/model.service';
import { take } from 'rxjs/operators';
import { AssignmentEdit } from '../../../models/assignment.model';

@Component({
  selector: 'app-new-assignment-page',
  templateUrl: './new-assignment-page.component.html',
  styleUrls: ['./new-assignment-page.component.scss']
})
export class NewAssignmentPageComponent implements OnInit, OnDestroy {

  routeSub: Subscription;
  courseId: string;

  constructor(private route: ActivatedRoute, private router: Router, private modelSvcFactory: ModelServiceFactory) { }

  ngOnInit() {
    this.save = this.save.bind(this);

    this.routeSub = this.route.parent.parent.paramMap
      .subscribe(params => {
        const courseSlug = params.get('slug');

        this.modelSvcFactory.courses.getBySlug(courseSlug)
          .pipe(take(1))
          .subscribe(courseResult => {
            this.courseId = courseResult.id;
          });
      });
  }

  save(assignment: AssignmentEdit) {
    return this.modelSvcFactory.assignments.save(assignment)
      .then(newAssign => {
        this.router.navigate(['../', 'assignment', newAssign.id], { relativeTo: this.route });
      });
  }

  ngOnDestroy(): void {
    this.routeSub.unsubscribe();
  }
}
