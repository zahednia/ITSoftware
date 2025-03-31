using ApplicationIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareDetail
{
    public class HardwareDetails : IHardwareDetails
    {
        private readonly IDatabaseContext database;

        public HardwareDetails(IDatabaseContext database)
        {
            this.database = database;
        }

        public List<string> GetCpuDetail()
        {
            var cpudetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 2 )
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return cpudetails;
        }

        public List<string> GetGPUDetail()
        {
            var gpudetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 6)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return gpudetails;
        }

        public List<string> GetHDDDetail()
        {
            var HDDdetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 4)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return HDDdetails;
        }

        public List<string> GetMotherboardDetail()
        {
            var Motherdetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 1)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return Motherdetails;
        }

        public List<string> GetRamDetail()
        {
            var Ramdetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 3)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return Ramdetails;
        }

        public List<string> GetSSDDetail()
        {
            var ssddetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == 5)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return ssddetails;
        }
    }
}
