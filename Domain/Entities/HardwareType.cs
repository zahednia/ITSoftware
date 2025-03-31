using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HardwareType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<HardwareBrand> HardwareBrand { get; set; }
        public List<HardwareDetail> HardwareDetail { get; set; }
    }
}
