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

        public bool CreateShip (ShipCreate model)
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
                       OriginName = e.OriginName,
                       Created_At = e.Created_At
                   }
                        );

                return query.ToArray();
            }
        }
    }
}
