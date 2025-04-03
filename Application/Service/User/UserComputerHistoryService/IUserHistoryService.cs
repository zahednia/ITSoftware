using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistoryService
{
    public interface IUserHistoryService
    {
        int CountUserComputerHistory(int computerId);
        List<UserComputerHistoryGridDto> GetUserComputerHistory(int computerId);
    }
}
