using ApplicationIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareBrand
{
    public class HardwareBrands : IHardwareBrands
    {
        private readonly IDatabaseContext database;

        public HardwareBrands(IDatabaseContext database)
        {
            this.database = database;
        }

        public List<string> GetCpuBrands()
        {
            var cpuBrands = database.HardwareBrands
                .Where(b => b.HardwareTypeId == 2)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return cpuBrands;
        }

        public List<string> GetGPUBrands()
        {
            var gpuBrands = database.HardwareBrands
                .Where(b => b.HardwareTypeId == 6)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return gpuBrands;
        }

        public List<string> GetHDDBrands()
        {
            var HDD = database.HardwareBrands
                .Where(b => b.HardwareTypeId == 4)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return HDD;
        }

        public List<string> GetMotherboardBrands()
        {
            var Board = database.HardwareBrands
                .Where(b => b.HardwareTypeId == 1)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return Board;
        }

        public List<string> GetRamBrands()
        {
            var ram = database.HardwareBrands
               .Where(b => b.HardwareTypeId == 3)
               .Select(b => b.Brand)
               .Distinct()
               .ToList();

            return ram;
        }

        public List<string> GetSSDBrands()
        {
            var ssd = database.HardwareBrands
                .Where(b => b.HardwareTypeId == 5)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return ssd;
        }
    }
}
