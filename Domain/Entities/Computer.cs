using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        
        public List<UserComputer> UserComputer { get; set; }
        public virtual ICollection<ComputerHardware> HardwareComponents { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
