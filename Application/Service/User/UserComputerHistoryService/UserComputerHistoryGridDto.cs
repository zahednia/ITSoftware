using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistoryService
{
    public class UserComputerHistoryGridDto
    {
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Status => IsDeactive ? "غیرفعال" : "فعال";
        public bool IsDeactive { get; set; }
    }
}
