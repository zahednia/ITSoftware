using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistory
{
    public class UserComputerHistoryDto
    {
        public string UserFullName { get; set; }
        public bool IsDeactive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
