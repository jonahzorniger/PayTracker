using PayTracker.Data;
using PayTracker.Models;
using PayTracker.Data;
using PayTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTracker.Services
{
    public class JobService
    {
        private readonly Guid _userId;

        public JobService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateJob(JobCreate model)
        {
            WorkTypeService workTypeService = new WorkTypeService(_userId);

            IEnumerable<WorkTypeListItem> listOfWorkTypes = workTypeService.GetWorkTypes();
            var entity =
                new Job()
                {
                    OwnerId = _userId,
                    WorkTypeId = model.WorkTypeId,
                    CustomerId = model.CustomerId,
                    Description = model.Description,
                    CreatedUtc = DateTimeOffset.Now,
                    SoldAmount = model.SoldAmount,
                    Earnings = model.Earnings,
                };
            using (var ctx = new ApplicationDbContext())
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
                                            WorkType = e.WorkType,
                                            Customer = e.Customer,
                                            Description = e.Description,
                                            SoldAmount = e.SoldAmount,
                                            Earnings = e.Earnings,
                                            CreatedUtc = e.CreatedUtc,
                                            ModifiedUtc = e.ModifiedUtc
                                        }

                                    );
                return query.ToArray();
            }
        }

        public JobDetail GetJobById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                            .Jobs
                            .Single(e => e.JobId == id && e.OwnerId == _userId);
                return
                    new JobDetail
                    {
                        JobId = entity.JobId,
                        WorkType = entity.WorkType,
                        Customer = entity.Customer,
                        Description = entity.Description,
                        CreatedDate = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc,
                        Earnings = entity.Earnings,
                        SoldAmount = entity.SoldAmount
                    };
            }
        }

        public bool UpdateJob(JobEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == model.JobId && e.OwnerId == _userId);

                entity.WorkTypeId = model.WorkTypeId;
                entity.CustomerId = model.CustomerId;
                entity.Description = model.Description;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;
                entity.SoldAmount = model.SoldAmount;
                entity.Earnings = model.Earnings;

                return ctx.SaveChanges() == 1;
               
            }
        }

        public bool DeleteJob(int jobId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == jobId && e.OwnerId == _userId);

                ctx.Jobs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
