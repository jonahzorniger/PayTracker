using JobTracker.Data;
using JobTracker.Models;
using PayTracker.Data;
using PayTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Services
{
    public class CustomerService
    {
        private readonly Guid _userId;

        public CustomerService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCustomer(CustomerCreate model)
        {
            var entity =
                new Customer()
                {
                    OwnerId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CustomerListItem> GetCustomer()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Customers
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new CustomerListItem
                                {
                                    CustomerId = e.CustomerId,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName
                                }
                        );
                return query.ToArray();
            }
        }
    }
}
