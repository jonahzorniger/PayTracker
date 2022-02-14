using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Data
{
    public class Customer
    {
        [Key]
       public int CustomerId { get; set; }

        [Required,
            MaxLength(100),
                MinLength(1)]
       public string FirstName { get; set; }

        [Required, 
            MaxLength(100),
                MinLength(1)]
       public string LastName { get; set; }
    }
}
