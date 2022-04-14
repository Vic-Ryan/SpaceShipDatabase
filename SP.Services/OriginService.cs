using SP.Data;
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services
{
    public class OriginService
    {
       private readonly Guid _userId;

       public OriginService(Guid userId)
       {
          _userId = userId;
       }

        public bool CreateOrigin(OriginCreate model)
        {
            var entity = new Origin()
            {
                OwnerId = _userId,
                OriginName = model.OriginName,
                RegisteredShips = model.RegisteredShips,
                CreationDate = model.CreationDate
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Origin.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<OriginListItem> GetOrigin()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                                .Origin
                                .Select(e => new OriginListItem()
                                {
                                    OriginID = e.OriginId,
                                    OriginName = e.OriginName,
                                    CreationDate = e.CreationDate,
                                    RegisteredShips = e.RegisteredShips
                                });
                return query.ToArray();
            }
        }
        public OriginDetail GetOriginById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                                .Origin
                                .Single(o => o.OriginId == id);

                return new OriginDetail()
                {
                    OriginId = entity.OriginId,
                    OriginName = entity.OriginName,
                    CreationDate = entity.CreationDate,
                    RegisteredShips = entity.RegisteredShips
                };
            }
        }
        public bool UpdateOrigin(OriginEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                                .Origin
                                .Single(o => o.OriginId == model.OriginId && o.OwnerId == _userId);
                entity.OriginName = model.OriginName;
                entity.RegisteredShips = model.RegisteredShips;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteOrigin(int originId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                                .Origin
                                .Single(e => e.OriginId == originId && e.OwnerId == _userId);

                ctx.Origin.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
