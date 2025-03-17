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
        public string Name { get; set; }
        public int HardwareTypeID { get; set; } // مثل "CPU", "RAM", "GPU"
        public virtual ICollection<HardwareModel> Models { get; set; } = new List<HardwareModel>();
    }
}
