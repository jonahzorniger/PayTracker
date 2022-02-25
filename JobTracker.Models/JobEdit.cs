using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PayTracker.Models
{
    public class JobEdit
    {
        public int JobId { get; set; }

        [Display(Name = "Work Type")]
        [ForeignKey("WorkTypeId")]
        public int WorkTypeId { get; set; }


        public virtual WorkType WorkType { get; set; }


        [Display(Name = "Customer")]
        [ForeignKey("CusomterId")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public string Description { get; set; }

        [Display(Name = "Sold Amount")]
        public decimal SoldAmount { get; set; }
        public decimal Earnings { get; set; }

    }
}