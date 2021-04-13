using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColonyManager.EfMigrations
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntity).Assembly);
        }
    }
}

