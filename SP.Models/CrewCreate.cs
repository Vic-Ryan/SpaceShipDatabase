using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Models
{
    public class CrewCreate
    {
        [Key]
        [Display(Name = "Crew ID")]
        public int CrewId { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset Created_At { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
        public string Ship { get; set; }

        //[ForeignKey(nameof(Origin))]
        [Display(Name = "Origin Name")]
        public virtual string OriginName { get; set; }

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
