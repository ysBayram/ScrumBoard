using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class SBCategory : SBInput
    {
        public ICollection<SBSprint> Sprints { get; set; }
        
    }
}
