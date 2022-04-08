using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class OriginDetail
    {
        public int OriginId { get; set; }
        public string OriginName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int RegisteredShips { get; set; }
    }
}
