using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class OriginCreate
    {
        [Required]
        public string OriginName { get; set; }
        [Required]
        public int RegisteredShips { get; set; }
        [Required]
        public DateTimeOffset CreationDate { get; set; }
    }
}
