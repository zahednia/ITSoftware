﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<HardwareType> HardwareTypes { get; set; }
        public DbSet<HardwareDetail> HardwareDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputer> UserComputers { get; set; }
        public DbSet<ChType> ChTypes { get; set; }
        public DbSet<ChStatus> ChStatuses { get; set; }
        public DbSet<ChMain> ChMains { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        public int SaveChanges();
    }
}
