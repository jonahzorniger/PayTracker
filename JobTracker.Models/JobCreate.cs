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
    public class JobCreate
    {
        [Display(Name = "Work Type")]
        [ForeignKey("WorkTypeId")]
        public int WorkTypeId { get; set; }


        public virtual WorkType WorkType { get; set; } 


        [MaxLength(8000)]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Sold Amount")]
        public int SoldAmount { get; set; }

        [Required]
        public int Earnings { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
