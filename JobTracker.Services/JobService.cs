using JobTracker.Data;
using JobTracker.Models;
using PayTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Services
{
    public class JobService
    {
        private readonly Guid _userId;

        public JobService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateJob (JobCreate model)
        {
            var entity =
                new Job()
                {
                    OwnerId = _userId,
                    JobName = model.JobName,
                    Description = model.Description,
                    CreatedUtc = DateTimeOffset.Now,
                    SoldAmount = model.SoldAmount,
                    Earnings = model.Earnings,
                };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Jobs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<JobListItem> GetJobs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                                .Jobs
                                .Where(e => e.OwnerId == _userId)
                                .Select(
                                    e =>
                                        new JobListItem
                                        {
                                            JobId = e.JobId,
                                            JobName = e.JobName,
                                            Description = e.Description,
                                            SoldAmount = e.SoldAmount,
                                            Earnings = e.Earnings,
                                            CreatedUtc = e.CreatedUtc
                                        }

                                    );
                return query.ToArray();
            }
        }
    }
}
