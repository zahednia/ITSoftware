using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ComputerHardware
    {

        public int Id { get; set; }
        public int ComputerId { get; set; } // Foreign Key به Computer
        public int HardwareDetailId { get; set; } // Foreign Key به HardwareDetail

        // Navigation Properties
        public Computer Computer { get; set; }
        public HardwareDetail HardwareDetail { get; set; }
    }
}
