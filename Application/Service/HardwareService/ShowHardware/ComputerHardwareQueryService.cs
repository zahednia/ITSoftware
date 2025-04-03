using ApplicationIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.ShowHardware
{
    public class ComputerHardwareQueryService : IComputerHardwareQueryService
    {
        private readonly IDatabaseContext context;

        public ComputerHardwareQueryService(IDatabaseContext context)
        {
            this.context = context;
        }

        public List<ComputerHardwareInfoDto> GetHardwareListForComputer(int computerId)
        {

            var list = context.ComputerHardwares
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareBrand)
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareDetail)
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareType)
                .Where(ch => ch.ComputerId == computerId && !ch.IsDeactive)
                .Select(ch => new ComputerHardwareInfoDto
                {
                    HardwareTypeId = ch.Hardware.HardwareTypeId,
                    Brand = ch.Hardware.HardwareBrand.Brand,
                    Detail = ch.Hardware.HardwareDetail.Detail
                })
                .ToList();

            return list;
        }
    }
}
