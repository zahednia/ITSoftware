using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KouroshDBS;Trusted_Connection=True;MultipleActiveResultSets=true;ConnectRetryCount=5;Encrypt=False;");
        }

        public DbSet<ComputerHardware> ComputerHardwares {  get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<HardwareBrand> HardwareBrands { get; set; }
        public DbSet<HardwareDetail> HardwareDetails { get; set; }
        public DbSet<HardwareType> HardwareTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputer> UserComputers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // تنظیم رفتار حذف برای HardwareDetail -> HardwareType
            modelBuilder.Entity<HardwareDetail>()
                .HasOne(hd => hd.HardwareType)
                .WithMany(ht => ht.HardwareDetail)
                .HasForeignKey(hd => hd.HardwareTypeId)
                .OnDelete(DeleteBehavior.NoAction); // تغییر به NoAction

            // تنظیم رفتار حذف برای HardwareDetail -> HardwareBrand
            modelBuilder.Entity<HardwareDetail>()
                .HasOne(hd => hd.HardwareBrand)
                .WithMany(hb => hb.HardwareDetail)
                .HasForeignKey(hd => hd.HardwareBrandId)
                .OnDelete(DeleteBehavior.NoAction); // تغییر به NoAction

            // تنظیم رفتار حذف برای HardwareBrand -> HardwareType
            modelBuilder.Entity<HardwareBrand>()
                .HasOne(hb => hb.hardwareType)
                .WithMany(ht => ht.HardwareBrand)
                .HasForeignKey(hb => hb.HardwareTypeId)
                .OnDelete(DeleteBehavior.NoAction); // تغییر به NoAction

            // سایر تنظیمات...
        }

    }
}
