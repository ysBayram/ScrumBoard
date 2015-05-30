using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class SBMeeting : SBInput
    {
        [MaxLength(250)]
        public string Descrp { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public virtual SBSprint Sprint { get; set; }

    }
}
