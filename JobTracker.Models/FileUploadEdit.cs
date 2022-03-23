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
    public class FileUploadEdit
    {
        public int FileUploadId { get; set; }

        [Display(Name = "Work Type")]
        [ForeignKey("WorkTypeId")]
        public int WorkTypeId { get; set; }


        public virtual WorkType WorkType { get; set; }


        [Display(Name = "Customer")]
        [ForeignKey("CusomterId")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
