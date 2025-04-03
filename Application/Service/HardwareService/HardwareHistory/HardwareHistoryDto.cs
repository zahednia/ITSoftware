using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.History
{
    public class HardwareHistoryDto
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
