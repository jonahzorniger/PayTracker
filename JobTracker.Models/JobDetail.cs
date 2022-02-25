using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PayTracker.Models
{
    public class JobDetail
    {
        public int JobId { get; set; }

        
        [ForeignKey("WorkTypeId")]
        public virtual WorkType WorkType { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

      
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