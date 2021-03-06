using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Display(Name ="Customer")]
        public virtual int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; } 

        [Display(Name ="Work Type")]
        public virtual int WorkTypeId { get; set; }

        [ForeignKey("WorkTypeId")]
        public virtual WorkType WorkType { get; set; }

        public string Description { get; set; }

        [Display(Name = "Sold Amount")]
        [Required]
        public decimal SoldAmount { get; set; }

        [Required]
        public decimal Earnings { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }


    }
}
