using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ComputerHardware
    {
        public int ComputerId { get; set; }
        public int HardwareDetailId { get; set; }
        public Computer Computer { get; set; }
        public HardwareDetail HardwareDetail { get; set; }
    }
}
