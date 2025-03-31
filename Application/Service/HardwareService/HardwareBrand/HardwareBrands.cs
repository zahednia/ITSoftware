using ApplicationIT.Database;
using Domain.Entities;
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

        public List<string> GetBrands(int hardwareTypeId)
        {
            var Brands = database.HardwareBrands
                .Where(b => b.HardwareTypeId == hardwareTypeId)
                .Select(b => b.Brand)
                .Distinct()
                .ToList();

            return Brands;
        }

    }
}
