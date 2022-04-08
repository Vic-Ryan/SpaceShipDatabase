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
        public bool CreateOrigin(OriginCreate model)
        {
            var entity = new Origin()
            {
                OriginName = model.OriginName,
                RegisteredShips = model.RegisteredShips,
                CreationDate = model.CreationDate
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Origins.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
