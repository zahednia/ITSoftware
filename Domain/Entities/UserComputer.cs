using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserComputer
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ComputerID { get; set; }
    }
}
