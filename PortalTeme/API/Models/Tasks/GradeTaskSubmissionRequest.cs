﻿using System.ComponentModel.DataAnnotations;

namespace PortalTeme.API.Models.Tasks {
    public class ReviewTaskSubmissionRequest {

        [Required]
        public string Review { get; set; }

        public int? Grade { get; set; }

    }
}
