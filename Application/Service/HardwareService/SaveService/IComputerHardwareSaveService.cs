using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.SaveService
{
    public interface IComputerHardwareSaveService
    {
        void SaveHardwareToComputer(SaveHardwareToComputerDto dto);
    }
}
