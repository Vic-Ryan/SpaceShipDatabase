using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class ShipEdit
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public int? OriginId { get; set; }
        public string Manufacturer { get; set; }
        public string ShipSize { get; set; }
        public string ShipPurpose { get; set; }
        public string CaptainName { get; set; }
        public int CrewSize { get; set; }
        public string Capacity { get; set; }
        public string TopSpeed { get; set; }
    }
}
