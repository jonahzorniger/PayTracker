using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PayTracker.Models
{
    public class FileUploadCreate
    {
        [Display(Name = "Work Type")]
        [ForeignKey("WorkTypeId")]
        public int WorkTypeId { get; set; }

        public virtual WorkType WorkType { get; set; }

        [Display(Name = "Customer")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } 

        public string Title { get; set; }

        [MaxLength (8000)]
        public string Description { get; set; }
        [AllowHtml]
        public string Contents { get; set; }

        public DateTimeOffset DateTimeOffset { get; set; }
        public byte[] Image { get; set; }

    }
}
