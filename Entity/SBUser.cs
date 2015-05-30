using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class SBUser : SBInput
    {
        [Required]
        public Role Role { get; set; }

        public ICollection<SBTask> Tasks { get; set; }

    }
}
