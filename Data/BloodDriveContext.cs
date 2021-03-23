using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BloodDriveDonation.Models;

namespace BloodDriveDonation.Data
{
    public class BloodDriveContext : DbContext
    {
        public BloodDriveContext(DbContextOptions<BloodDriveContext> options) : base(options)
        {

        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
