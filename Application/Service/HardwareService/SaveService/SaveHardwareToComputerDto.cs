using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.SaveService
{
    public class SaveHardwareToComputerDto
    {
        public int ComputerId { get; set; }
        public string HardwareType { get; set; }   // مثل RAM
        public string HardwareBrand { get; set; }  // مثل ADATA
        public string HardwareDetail { get; set; } // مثل DDR4 8GB
    }
}
