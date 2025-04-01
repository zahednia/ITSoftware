using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HardwareDetail
    {
        public int Id { get; set; }
        public HardwareType HardwareType { get; set; }
        public int HardwareTypeId { get; set; }
        public HardwareBrand HardwareBrand { get; set; }
        public int HardwareBrandId { get; set; }
        public string Detail { get; set; }

        public virtual ICollection<ComputerHardware> ComputerHardwares { get; set; }

    }
}
