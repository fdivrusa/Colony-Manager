using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ColonyTypeConfiguration : ConfigBaseConfiguration<ColonyType>
    {
        public override void Configure(EntityTypeBuilder<ColonyType> builder)
        {
            builder.ToTable("ColonyTypes");
            base.Configure(builder);
        }
    }
}
