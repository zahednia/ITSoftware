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
        public int HardwareTypeId { get; set; }
        public int HardwareDetailId { get; set; }

    }
}
