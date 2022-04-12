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
        public int CrewId { get; set; }
        [Required]
        public DateTimeOffset Created_At { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public string Ship { get; set; }

        //[ForeignKey(nameof(Origin))]
        public virtual string OriginName { get; set; }
        public string CrewName { get; set; }
        public string CrewRole { get; set; }
        public string CrewDescription { get; set; }
        public string CrewMembers { get; set; }


    }
}
