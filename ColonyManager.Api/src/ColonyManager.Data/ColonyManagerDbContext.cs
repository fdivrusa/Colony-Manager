using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColonyManager.Data
{
    public class ColonyManagerDbContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }

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
