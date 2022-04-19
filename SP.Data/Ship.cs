using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data
{
    public class Ship
    {
        [Key]
        public int Id { get; set; }
       // [Required]
       // public Guid OwnerId { get; set; }
        [Required]
        public string ShipName { get; set; }
        public DateTimeOffset Created_At { get; set; }
        //[ForeignKey(nameof(Origin))]
        public string OriginName { get; set; }
        //public virtual Origin Origin { get; set; } 
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string ShipSize { get; set; } //Maybe an int?
        [Required]
        public string ShipPurpose { get; set; }
        [Required]
        public string CaptainName { get; set; }
        [Required]
        public int CrewSize { get; set; }
        public ICollection<Crew> Crew { get; set; }
        [Required]
        public string Capacity { get; set; }
        [Required]
        public string TopSpeed { get; set; } //Also maybe an int?
    }
}
