using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class CrewEdit
    {
        [Display(Name = "Crew ID")]
        public int CrewId { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset Created_At { get; set; }
        [Display(Name = "Modified")]
        public DateTimeOffset Modified_At { get; set; }

        public Guid OwnerId { get; set; }
        public string ShipName { get; set; }
        //[ForeignKey(nameof(Origin))]
        [Display(Name = "Origin Name")]
        public  string OriginName { get; set; }

        [Display(Name = "Crew Name")]
        public string CrewName { get; set; }

        [Display(Name = "Crew's Role")]
        public string CrewRole { get; set; }

        [Display(Name = "Description of crew")]
        public string CrewDescription { get; set; }

        [Display(Name = "Accompaniment")]
        public string CrewMembers { get; set; }
    }
}
