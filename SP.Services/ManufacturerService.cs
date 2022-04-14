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
    }
}
