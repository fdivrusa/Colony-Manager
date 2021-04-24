using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColonyManager.Data
{
    public class ColonyManagerDbContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<ConfigGenericGroup> ConfigGenericGroups { get; set; }
        public DbSet<ConfigGenericItem> ConfigGenericItems { get; set; }
        public DbSet<ConfigGenericItemExtension> ConfigGenericItemExtensions { get; set; }
        public DbSet<ConfigGenericItemExtensionValue> ConfigGenericItemExtensionValues { get; set; }
        public DbSet<SystemDataType> SystemDataTypes { get; set; }
        public DbSet<PeoplePhoneInformation> PeoplePhoneInformations { get; set; }
        public DbSet<PeopleInternetInformation> PeopleInternetInformations { get; set; }
        public DbSet<Colony> Colonies { get; set; }
        public DbSet<ColonyBuilding> ColonyBuildings { get; set; }
        public DbSet<ColonyBuildingRoom> ColonyBuildingRooms { get; set; }


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
