using PayTracker.Data;
using PayTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PayTracker.Services
{
    public class WorkTypeService
    {
        private readonly Guid _userId;

        public WorkTypeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateWorkType(WorkTypeCreate model)
        {
            var entity =
                new WorkType()
                {
                    OwnerId = _userId,
                    WorkTypeName = model.WorkType,
                    Description = model.Description,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.WorkTypes.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<WorkTypeListItem> GetWorkTypes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .WorkTypes
                        .Select(
                            e =>
                                new WorkTypeListItem
                                {
                                    WorkTypeId = e.WorkTypeId,
                                    WorkTypeName = e.WorkTypeName,
                                    CreatedUtc = e.CreatedUtc
                                }
                     );
                return query.ToArray();
            }
        }

        public WorkTypeDetail GetWorkTypeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = 
                    ctx
                        .WorkTypes
                        .Single(e => e.WorkTypeId == id);
                return
                    new WorkTypeDetail
                    {
                        WorkTypeId = entity.WorkTypeId,
                        WorkTypeName = entity.WorkTypeName,
                        Description = entity.Description,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateWorkType(WorkTypeEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                           .WorkTypes
                           .Single(e => e.WorkTypeId == model.WorkTypeId);
                
                entity.WorkTypeName = model.WorkTypeName;
                entity.Description = model.Description;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteWorkType(int worktypeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .WorkTypes
                        .Single(e => e.WorkTypeId == worktypeId);

                ctx.WorkTypes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
