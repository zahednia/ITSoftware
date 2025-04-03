using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistory
{
    public interface IUserComputerHistoryService
    {
        List<UserComputerHistoryDto> GetHistory(int computerId);
    }

}
