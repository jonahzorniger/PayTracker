﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class JobCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public string JobName { get; set; }

        [MaxLength(8000)]
        public string Description { get; set; }

        [Required]
        public int SoldAmount { get; set; }

        [Required]
        public int Earnings { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
