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
        [Key]
        public int FileUploadId { get; set; }
        
        [Display(Name = "Work Type")]
        public string WorkTypeId { get; set; }

        [ForeignKey("WorkTypeId")]
        public virtual WorkType WorkType { get; set; }
       
        [Display(Name = "Customer")]
        public string CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Contents { get; set; }
        public byte[] Image { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
