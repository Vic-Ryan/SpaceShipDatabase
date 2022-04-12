using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class CrewListItem
    {
        [Display(Name="Crew ID")]
        public int CrewId { get; set; }
        [Display(Name="Crew Name")]
        public string CrewName { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset Created_At { get; set; }
        [Display(Name="Origin Name")]
        public virtual string OriginName { get; set; }
    }
}