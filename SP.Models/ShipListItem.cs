using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class ShipListItem
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public int? OriginId { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset Created_At { get; set; }
    }
}
