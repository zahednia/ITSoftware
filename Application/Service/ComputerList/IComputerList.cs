using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.ComputerList
{
    public interface IComputerList
    {
        List<ComputerListDTO> ComputerLists(string searchKey = null);
    }
}
