using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.AssignUserToComputer
{
    public interface IUserComputerAssignService
    {
        void AssignUserToComputer(AssignUserToComputerDto dto);
    }

}
