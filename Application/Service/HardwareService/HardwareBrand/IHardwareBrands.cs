using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareBrand
{
    public interface IHardwareBrands
    {
        List<string> GetCpuBrands();
        List<string> GetMotherboardBrands();
        List<string> GetRamBrands();
        List<string> GetHDDBrands();
        List<string> GetSSDBrands();
        List<string> GetGPUBrands();
    }
}
