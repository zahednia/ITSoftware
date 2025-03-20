using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KouroshCEOs;Trusted_Connection=True;MultipleActiveResultSets=true;ConnectRetryCount=5;Encrypt=False;");
        }

        public DbSet<ComputerHardware> ComputerHardwares { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<HardwareDetail> HardwareDetails { get; set; }
        public DbSet<HardwareType> HardwareTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputer> UserComputers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerHardware>()
                .HasKey(ch => new { ch.ComputerId, ch.HardwareDetailId });

            modelBuilder.Entity<ComputerHardware>()
                .HasOne(ch => ch.Computer)
                .WithMany(c => c.HardwareComponents)
                .HasForeignKey(ch => ch.ComputerId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<ComputerHardware>()
                .HasOne(ch => ch.HardwareDetail)
                .WithMany()
                .HasForeignKey(ch => ch.HardwareDetailId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
