using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        List<CheckList> CheckList { get; set; }
    }
}
