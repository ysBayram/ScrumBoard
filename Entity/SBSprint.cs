using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class SBSprint : SBInput
    {
        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        public virtual SBCategory Category { get; set; }

        public ICollection<SBMeeting> Meetings { get; set; }

        public ICollection<SBTask> Tasks { get; set; }
        
    }
}
