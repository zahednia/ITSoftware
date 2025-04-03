using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.ShowHardware
{
    public interface IComputerHardwareQueryService
    {
        List<ComputerHardwareInfoDto> GetHardwareListForComputer(int computerId);
    }
}
