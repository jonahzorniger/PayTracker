using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class JobListItem
    {
        public int JobId { get; set; }

        [Display(Name="Work Type")]
        [ForeignKey(nameof(WorkTypeId))]
        public int WorkTypeId { get; set; }

       

        public string Description { get; set; }

        [Required]
        public decimal SoldAmount { get; set; }

        [Required]
        public decimal Earnings { get; set; }


        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
