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
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]

        [Display(Name ="Work Type")]
        [ForeignKey("WorkTypeId")]
        public virtual WorkType WorkType { get; set; }

       

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
