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
        public User User { get; set; } 
        public Computer Computer { get; set; }
        public int ComputerID { get; set; }
        public bool IsDeactive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
