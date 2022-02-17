using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }


        [Required]
        public int CustomerId { get; set; }


        [Display(Name ="Work Type")]
        public string WorkType { get; set; }

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
