using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;


namespace ApplicationIT.Database
{
    public interface IDatabaseContext : IDisposable
    {
        public DbSet<ComputerHardware> ComputerHardwares { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<HardwareBrand> HardwareBrands { get; set; }
        public DbSet<HardwareModel> HardwareModels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputer> UserComputers { get; set; }

    }
}
