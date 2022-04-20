using SP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class JoiningCrewShip
    {
        //Junction Table
        [Key]
        public int CrewShipId { get; set; }

        [Required]
        public string RoleOnShip { get; set; }

        [Required] 
        public string Description { get; set; }

        [Required] 
        [ForeignKey(nameof(Crew))]
        public virtual Crew Ship { get; set; }

        [Required]
        [ForeignKey(nameof(Ship))]
        public virtual string ShipName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [DataType(DataType.DateTime)]
        public DateTimeOffset Created_At { get; set; }



    }
}
