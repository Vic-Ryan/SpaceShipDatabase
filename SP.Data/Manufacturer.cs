using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset Created_At { get; set; }
        [Required]
        public string ManufacturerName { get; set; }
        public List<Ship> ListOfShips { get; set; }
        public int? NumberOfShips { get; set; } 
    }
}
