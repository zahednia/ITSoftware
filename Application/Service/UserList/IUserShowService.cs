using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.UserService
{
    public interface IUserShowService
    {
        List<UserShowServiceDTO> Execute(string searchKey = null);
    }
}