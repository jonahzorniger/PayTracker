﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class CustomerDetail
    {
        public int CustomerId { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}