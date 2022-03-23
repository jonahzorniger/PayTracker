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
    public class FileUploadDetail
    { 
        public int FileUploadId { get; set; }

        [ForeignKey("WorkTypeId")]
        public virtual WorkType WorkType { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        [AllowHtml]

        [Display(Name = "Created")]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

        public string Contents { get; set; }
        public byte[] Image { get; set; }
    }

}
}
