using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Data
{
    public class WorkType
    {
        [Key]
        public int WorkTypeId { get; set; }

        [Required,
            MaxLength(100),
                MinLength(1)]
        public string WorkTypeName { get; set; }

        public string Description { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreateUtc { get; set; }

        [Display (Name ="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
