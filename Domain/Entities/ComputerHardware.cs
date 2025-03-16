using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ComputerHardware
    {
        public int Id { get; set; }
        public int HardwareID { get; set; }
        public int ComputerID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool IsActive { get; set; }

    }
}
