using ApplicationIT.Database;
using ApplicationIT.Service.HardwareService.History;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareHistory
{
    public class ComputerHardwareHistoryService : IComputerHardwareHistoryService
    {
        private readonly IDatabaseContext context;

        public ComputerHardwareHistoryService(IDatabaseContext context)
        {
            this.context = context;
        }

        public List<HardwareHistoryDto> GetHistory(int computerId, int hardwareTypeId)
        {
            return context.ComputerHardwares
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareBrand)
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareDetail)
                .Include(ch => ch.Hardware)
                    .ThenInclude(h => h.HardwareType)
                .Where(ch => ch.ComputerId == computerId &&
                             ch.Hardware.HardwareTypeId == hardwareTypeId &&
                             ch.IsDeactive == true)
                .Select(ch => new HardwareHistoryDto
                {
                    Type = ch.Hardware.HardwareType.Type,
                    Brand = ch.Hardware.HardwareBrand.Brand,
                    Detail = ch.Hardware.HardwareDetail.Detail,
                    CreatedAt = ch.CreatedAt,
                    UpdatedAt = ch.UpdatedAt
                })
                .ToList();
        }
        public int CountHistory(int computerId, int hardwareTypeId)
        {
            return context.ComputerHardwares
                .Include(ch => ch.Hardware)
                .Where(ch => ch.ComputerId == computerId &&
                             ch.Hardware.HardwareTypeId == hardwareTypeId &&
                             ch.IsDeactive)
                .Count();
        }
    }
}
