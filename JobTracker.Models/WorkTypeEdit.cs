using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Models
{
    public class WorkTypeEdit
    {
        public int WorkTypeId { get; set; }

        [Display(Name ="Work Type")]
        public string WorkTypeName { get; set; }
        public string Description { get; set; }
    }
}
