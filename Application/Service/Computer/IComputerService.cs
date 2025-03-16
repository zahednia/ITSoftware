using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.Computer
{
    public interface IComputerService
    {
        bool RegisterOrUpdateComputer(string computerCode, int userId);
        List<ComputerWithUsersDto> GetAllComputersWithUsers(); // متد جدید برای دریافت لیست کامپیوترها و کاربران
    }
}
