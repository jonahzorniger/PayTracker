using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Models
{
    public class CustomerListItem
    {
        [Display(Name ="Customer ID")]
        public int CustomerId { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get { return string.Concat(FirstName + " " + LastName); } }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
