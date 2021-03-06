﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PortalTeme.Data.Models.Assignments.Projections {
    public class StudentTaskProjectionBase {

        public Guid CourseId { get; set; }

        public AssignmentTask Task { get; set; }

        public string StudentId { get; set; }

        public StudentAssignedTaskState State { get; set; }

        public string Review { get; set; }

        public int? FinalGrading { get; set; }

    }

    public class StudentTaskProjection : StudentTaskProjectionBase {
        public Guid Id { get; set; }
        public List<TaskSubmission> Submissions { get; set; }
        public StudentInfo Student { get; set; }
    }
}
