using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required,
            MaxLength(100),
                MinLength(1)]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [Required,
            MaxLength(100),
                MinLength(1)]
        public decimal Price { get; set; }

    }
}
