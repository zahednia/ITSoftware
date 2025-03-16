using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        // شناسه کامپیوتر
        public int ComputerId { get; set; }

        // ارتباط با کامپیوتر
        public virtual Computer Computer { get; set; }
    }
}
