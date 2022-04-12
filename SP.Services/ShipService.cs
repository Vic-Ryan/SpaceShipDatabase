using SP.Data;
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services
{
    public class ShipService
    {
        private readonly Guid _userId;

        public ShipService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateShip(ShipCreate model)
        {
            var entity = new Ship()
            {
                OwnerId = _userId,
                ShipName = model.ShipName,
                Manufacturer = model.Manufacturer,
                ShipSize = model.ShipSize,
                ShipPurpose = model.ShipPurpose,
                CaptainName = model.CaptainName,
                CrewSize = model.CrewSize,
                Capacity = model.Capacity,
                TopSpeed = model.TopSpeed
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ships.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ShipListItem> GetShips()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Ships
                    .Where(e => e.OwnerId == _userId)
                    .Select
                    (e =>
                   new ShipListItem
                   {
                       ShipId = e.Id,
                       ShipName = e.ShipName,
                       OriginId = e.OriginId,
                       Created_At = e.Created_At
                   }
                        );

                return query.ToArray();
            }
        }

        public ShipDetail GetShipById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Ships
                    .Single(e => e.Id == id && e.OwnerId == _userId);
                return
                    new ShipDetail
                    {
                        Id = entity.Id,
                        ShipName = entity.ShipName,
                        OriginId = entity.OriginId,
                        Manufacturer = entity.Manufacturer,
                        ShipSize = entity.ShipSize,
                        ShipPurpose = entity.ShipPurpose,
                        CaptainName = entity.CaptainName,
                        CrewSize = entity.CrewSize,
                        Capacity = entity.Capacity,
                        TopSpeed = entity.TopSpeed
                    };
            }
        }

        public bool UpdateShip(ShipEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Ships.Single(e => e.Id == model.Id && e.OwnerId == _userId);

                entity.ShipName = model.ShipName;
                entity.OriginId = model.OriginId;
                entity.Manufacturer = model.Manufacturer;
                entity.ShipSize = model.ShipSize;
                entity.ShipPurpose = model.ShipPurpose;
                entity.CaptainName = model.CaptainName;
                entity.CrewSize = model.CrewSize;
                entity.Capacity = model.Capacity;
                entity.TopSpeed = model.TopSpeed;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteShip(int shipId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Ships
                    .Single(e => e.Id == shipId && e.OwnerId == _userId);

                ctx.Ships.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
