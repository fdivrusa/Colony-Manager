using Microsoft.EntityFrameworkCore;
using System;

namespace ColonyManager.Data
{
    public class ColonyManagerDbContext : DbContext
    {

        public ColonyManagerDbContext(DbContextOptions<ColonyManagerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColonyManagerDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
