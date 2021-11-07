using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class BuildingTypeConfiguration : ConfigBaseConfiguration<BuildingType>
    {
        public override void Configure(EntityTypeBuilder<BuildingType> builder)
        {
            builder.ToTable("BuildingTypes");
            base.Configure(builder);
        }
    }
}
