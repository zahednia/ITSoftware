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
        public Computer()
        {
            HardwareComponents = new List<ComputerHardware>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public ICollection<ComputerHardware> HardwareComponents { get; set; }
    }
}
