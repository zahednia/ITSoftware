using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Hardware
    {
        public int Id { get; set; }
        public HardwareDetail HardwareDetail { get; set; }
        public int HardwareDetailId { get; set; }
        public HardwareType HardwareType { get; set; }
        public int HardwareTypeId { get; set; }
        public HardwareBrand HardwareBrand { get; set; }
        public int HardwareBrandId { get; set; }
    }
}
