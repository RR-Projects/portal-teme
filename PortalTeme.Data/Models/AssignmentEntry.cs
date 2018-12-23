﻿using PortalTeme.Data.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalTeme.Data.Models {
    public class AssignmentEntry {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Assignment Assignment { get; set; }

        [Required]
        public User Student { get; set; }

        [Required]
        public AssignmentEntryState State { get; set; }

        public int? Grading { get; set; }
    }

    public enum AssignmentEntryState {
        Submitted,
        Reviewed,
        Graded
    }
}
