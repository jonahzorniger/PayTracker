using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Data
{
    public class WorkType
    {
        [Key]
        public int WorkTypeId { get; set; }

        public Guid OwnerId { get; set; }

        [Required,
            MaxLength(100),
                MinLength(1)]

        [Display(Name =" Work Type")]
        public string WorkTypeName { get; set; }

        public string Description { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display (Name ="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
