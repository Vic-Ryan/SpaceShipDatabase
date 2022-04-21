using SP.Data;
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services
{
    public class ManufacturerService
    {
        private readonly Guid _userId;

        public ManufacturerService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateManufacturer(ManufacturerCreate model)
        {
            var entity = new Manufacturer()
            {
                OwnerId = _userId,
                ManufacturerName = model.ManufacturerName,
                Created_At = DateTimeOffset.Now,
                NumberOfShips = model.NumberOfShips,
                ListOfShips = model.ListOfShips
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Manufacturers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ManufacturerListItem> GetManufacturers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Manufacturers
                    .Select(e => new ManufacturerListItem()
                    {
                        Id = e.Id,
                        ManufacturerName = e.ManufacturerName,
                        NumberOfShips = e.NumberOfShips
                    });

                return query.ToArray();
            }
        }

        public ManufacturerDetail GetManufacturerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Manufacturers
                    .Single(e => e.Id == id);

                return new ManufacturerDetail()
                {
                    Id = entity.Id,
                    ManufacturerName = entity.ManufacturerName,
                    ListOfShips = entity.ListOfShips,
                    Created_At = entity.Created_At
                };
            }
        }

        public bool UpdateManufacturer (ManufacturerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Manufacturers.Single(e => e.Id == model.Id && e.OwnerId == _userId);

                entity.ManufacturerName = model.ManufactuerName;
                entity.Edited_At = DateTimeOffset.Now;
                entity.ListOfShips = model.ListOfShips;
                entity.NumberOfShips = model.NumberOfShips;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteManufacturer(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Manufacturers
                    .Single(e => e.Id == id && e.OwnerId == _userId);

                ctx.Manufacturers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
