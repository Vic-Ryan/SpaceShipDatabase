using SP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class ManufacturerCreate
    {
        [Required]
        public string ManufacturerName { get; set; }
        [Required]
        public int NumberOfShips { get; set; }
        public List<Ship> ListOfShips { get; set; }
        public DateTimeOffset Created_At { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
    }

    public class ManufacturerEdit
    {
        public int Id { get; set; }
        public string ManufactuerName { get; set; }
        public int? NumberOfShips { get; set; }
        public List<Ship> ListOfShips { get; set; }
        public DateTimeOffset Edited_On { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
    }

    public class ManufacturerListItem
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public int? NumberOfShips { get; set; }
    }

    public class ManufacturerDetail
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset Created_At { get; set; }
        public List<Ship> ListOfShips { get; set; }
        public int? NumberOfShip { get; set; }
    }
}
