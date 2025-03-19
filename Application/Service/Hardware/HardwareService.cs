using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.Hardware
{
    public class HardwareService : IHardwareService
    {
        private readonly IDatabaseContext database;

        public HardwareService(IDatabaseContext database)
        {
            this.database = database;
        }
        public List<HardwareType> GetAllHardwareTypes()
        {
                return database.HardwareTypes.ToList();
        }

        public void SaveHardwareDetail(HardwareDetail detail)
        {
            database.HardwareDetails.Add(detail);
            database.SaveChanges();
        }
    }
}
