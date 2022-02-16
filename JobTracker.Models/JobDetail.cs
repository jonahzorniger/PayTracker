using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PayTracker.Models
{
    public class JobDetail
    {
        public int JobId { get; set; }

        [Display(Name = "Work Type")]
        public string WorkType { get; set; }
        public string Description { get; set; }

        public decimal Earnings { get; set; }

        [Display(Name = "Sold Amount")]
        public decimal SoldAmount { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}