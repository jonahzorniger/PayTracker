using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Data
{
    public class Customer
    {
        [Key]
        [Display(Name ="Customer ID")]

        public int CustomerId { get; set; }

        public Guid OwnerId { get; set; }

        

        [Required,
         MaxLength(100),
         MinLength(1)]
       public string FirstName { get; set; }

        [Required, 
            MaxLength(100),
                MinLength(1)]
       public string LastName { get; set; }


        [Display(Name ="Customer")]
        public string FullName { get { return string.Concat(FirstName + " " + LastName); } }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name ="Updated")]

        public DateTimeOffset ModifiedUtc { get; set; }

    }
}
