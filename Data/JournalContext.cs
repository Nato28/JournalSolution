using JournalVersion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalVersion.Data
{
    public class JournalContext : DbContext
    {
        public JournalContext(DbContextOptions<JournalContext> options) : base(options)
        {
        }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<IISSetting> IisSettings { get; set; }
        public DbSet<DataBaseSetting> DataBaseSettings { get; set; }
        public DbSet<UserApplicationTest> UserApplicationTests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solution>().ToTable("Solution");
            modelBuilder.Entity<IISSetting>().ToTable("IISSetting");
            modelBuilder.Entity<IISSetting>().ToTable("DataBaseSetting");
            modelBuilder.Entity<UserApplicationTest>().ToTable("UserApplicationTest");
        }
    }
}
