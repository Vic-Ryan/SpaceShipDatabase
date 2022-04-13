using SP.Data;
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services
{
    public class CrewService
    {
        private readonly Guid _userId;

        public CrewService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCrew(CrewCreate model)
        {
            var entity =
                new Crew()
                {
                    OwnerId = _userId,
                    Created_At = DateTimeOffset.Now,
                    CrewId = model.CrewId,
                    Ship = model.Ship,
                    OriginName = model.OriginName,
                    CrewName = model.CrewName,
                    CrewRole = model.CrewRole,
                    CrewDescription = model.CrewDescription,
                    CrewMembers = model.CrewMembers
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Crews.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CrewListItem> GetCrews()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Crews
                        //.Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new CrewListItem
                                {
                                    CrewId = e.CrewId,
                                    CrewName = e.CrewName,
                                    OriginName = e.OriginName,
                                    Ship = e.Ship,
                                    Created_At = e.Created_At
                                }
                       );
                return query.ToArray();
            }
        }

        public CrewDetail GetCrewsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == id);
                return
                    new CrewDetail
                    {
                        OwnerId = _userId,
                        Created_At = entity.Created_At,
                        CrewId = entity.CrewId,
                        Ship = entity.Ship,
                        OriginName = entity.OriginName,
                        CrewName = entity.CrewName,
                        CrewRole = entity.CrewRole,
                        CrewDescription = entity.CrewDescription,
                        CrewMembers = entity.CrewMembers
                    };
            }
        }
        public bool UpdateCrew(CrewEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == model.CrewId && e.OwnerId == _userId);

                entity.OwnerId = _userId;
                entity.Created_At = model.Created_At;
                entity.Modified_At = DateTimeOffset.UtcNow;
                entity.CrewId = model.CrewId;
                entity.Ship = model.Ship;
                entity.OriginName = model.OriginName;
                entity.CrewName = model.CrewName;
                entity.CrewRole = model.CrewRole;
                entity.CrewDescription = model.CrewDescription;
                entity.CrewMembers = model.CrewMembers;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCrew(int crewId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == crewId && e.OwnerId == _userId);
                ctx.Crews.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
