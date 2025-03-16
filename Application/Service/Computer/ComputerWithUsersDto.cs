using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.Computer
{
    public class ComputerWithUsersDto
    {
        public int ComputerId { get; set; }
        public string ComputerCode { get; set; }
        public List<UserDto> Users { get; set; } = new List<UserDto>();
    }
    public class UserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}
