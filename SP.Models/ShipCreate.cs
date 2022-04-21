using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class ShipCreate
    {
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string ShipSize { get; set; }
        [Required]
        public string ShipPurpose { get; set; }
        [Required]
        public string CaptainName { get; set; }
        [Required]
        public int CrewSize { get; set; }
        [Required]
        public string Capacity { get; set; }
        [Required]
        public string TopSpeed { get; set; }
        [Required]
        public string OriginName { get; set; }
    }
}
