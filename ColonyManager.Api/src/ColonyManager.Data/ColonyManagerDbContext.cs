using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColonyManager.Data
{
    public class ColonyManagerDbContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<PeoplePhoneInformation> PeoplePhoneInformations { get; set; }
        public DbSet<PeopleInternetInformation> PeopleInternetInformations { get; set; }
        public DbSet<Colony> Colonies { get; set; }
        public DbSet<ColonyBuilding> ColonyBuildings { get; set; }
        public DbSet<ColonyBuildingRoom> ColonyBuildingRooms { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<AttributionType> AttributionTypes { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<ColonyType> ColonyTypes { get; set; }
        public DbSet<Gender> GenderTypes { get; set; }
        public DbSet<PhoneInformationType> PhoneInformationTypes { get; set; }
        public DbSet<InternetInformationType> InternetInformationTypes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }


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
