using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public string JobName { get; set; }

        public string Description { get; set; }

        [Required]
        public int SoldAmount { get; set; }

        [Required]
        public int Earnings { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }


    }
}
