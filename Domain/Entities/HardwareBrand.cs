using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HardwareBrand
    {
        public int Id { get; set; }
        public HardwareType hardwareType { get; set; }
        public int HardwareTypeId { get; set; }
        public string? Brand { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<HardwareDetail> HardwareDetail { get; set; }
    }
}
