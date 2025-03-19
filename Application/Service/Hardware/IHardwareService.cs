using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.Hardware
{
    public interface IHardwareService
    {
        List<HardwareType> GetAllHardwareTypes();
        void SaveHardwareDetail(HardwareDetail detail);
    }
}
