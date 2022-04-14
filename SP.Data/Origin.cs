using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data
{
    public class Origin
    {
        [Key]
        public int OriginId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string OriginName { get; set; }
        [Required]
        public DateTimeOffset CreationDate { get; set; }
        [Required]
        public int RegisteredShips { get; set; }

        
    }
}
