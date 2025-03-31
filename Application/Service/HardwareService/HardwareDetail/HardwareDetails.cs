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

        public List<string> GetDetail(int HardwareTypeId)
        {
            var cpudetails = database.HardwareDetails
                .Where(b => b.HardwareTypeId == HardwareTypeId)
                .Select(b => b.Detail)
                .Distinct()
                .ToList();

            return cpudetails;
        }

    }
}
