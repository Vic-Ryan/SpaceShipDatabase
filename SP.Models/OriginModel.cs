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
    public class OriginEdit
    {
        public int OriginId { get; set; }
        public string OriginName { get; set; }
        public int RegisteredShips { get; set; }
    }
    public class OriginListItem
    {
        public int OriginID { get; set; }
        public string OriginName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int RegisteredShips { get; set; }

    }
    public class OriginDetail
    {
        public int OriginId { get; set; }
        public string OriginName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int RegisteredShips { get; set; }
    }
}
