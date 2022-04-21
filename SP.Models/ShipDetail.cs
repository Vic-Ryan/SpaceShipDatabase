using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class ShipDetail
    {
        
        public int Id { get; set; }
        //public Guid OwnerId { get; set; }
        public string ShipName { get; set; }
        [Display(Name ="Created")]
        public DateTimeOffset Created_At { get; set; }
        public string OriginName { get; set; }
        public string Manufacturer { get; set; }
        public string ShipSize { get; set; } 
        public string ShipPurpose { get; set; }
        public string CaptainName { get; set; }
        public int CrewSize { get; set; }
        public string Crew { get; set; }
        public string Capacity { get; set; }
        public string TopSpeed { get; set; } 
    }
}
