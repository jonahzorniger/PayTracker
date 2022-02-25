using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Models
{
    public class JobListItem
    {
        [Display(Name ="Job ID")]
        public int JobId { get; set; }

       
        [ForeignKey("Work Type ID")]
        public virtual WorkType WorkType { get; set; }

        [ForeignKey("Customer ID")]
        public virtual Customer Customer { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name ="Sold Amount")]
        public decimal SoldAmount { get; set; }

        [Required]
        public decimal Earnings { get; set; }


        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
