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
    public class FileUploadListItem
    {
        public int FileUploadId { get; set; }

        [ForeignKey("Work Type ID")]
        public virtual WorkType WorkType { get; set; }

        [ForeignKey("Customer ID")]
        public virtual Customer Customer { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
