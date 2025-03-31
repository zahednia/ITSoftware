using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareDetail
{
    public interface IHardwareDetails
    {
        List<string> GetCpuDetail();
        List<string> GetMotherboardDetail();
        List<string> GetRamDetail();
        List<string> GetHDDDetail();
        List<string> GetSSDDetail();
        List<string> GetGPUDetail();
    }
}
