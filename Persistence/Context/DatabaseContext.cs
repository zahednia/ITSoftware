using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationIT.Database;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITSoftWare;Integrated Security=True;Encrypt=False;");
        }

        public DbSet<ComputerHardware> ComputerHardwares {  get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<HardwareDetail> HardwareDetails { get; set; }
        public DbSet<HardwareType> HardwareTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputer> UserComputers { get; set; }
    }
}
