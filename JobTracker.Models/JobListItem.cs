using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class JobListItem
    {
        public int JobId { get; set; }


        public string JobName { get; set; }

        public string Description { get; set; }

        [Required]
        public int SoldAmount { get; set; }

        [Required]
        public int Earnings { get; set; }


        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
