using ColonyManager.Data.DataSeeds;
using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class NationalityConfiguration : ConfigBaseConfiguration<Nationality>
    {
        public override void Configure(EntityTypeBuilder<Nationality> builder)
        {
            builder.ToTable("Nationalities");
            builder.HasData(NationalitiesDataSeeding.GetData());
            base.Configure(builder);
        }
    }
}
