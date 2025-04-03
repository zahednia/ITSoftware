using ApplicationIT.Service.HardwareService.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareHistory
{
    public interface IComputerHardwareHistoryService
    {
        List<HardwareHistoryDto> GetHistory(int computerId, int hardwareTypeId);
        int CountHistory(int computerId, int hardwareTypeId);

    }
}
