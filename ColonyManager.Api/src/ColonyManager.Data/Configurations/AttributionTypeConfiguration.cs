using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class AttributionTypeConfiguration : ConfigBaseConfiguration<AttributionType>
    {
        public override void Configure(EntityTypeBuilder<AttributionType> builder)
        {
            builder.ToTable("AttributionTypes");
            base.Configure(builder);
        }
    }
}
