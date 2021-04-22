using ColonyManager.Data.DataSeeds;
using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ConfigGenericGroupConfiguration : BaseConfiguration<ConfigGenericGroup>
    {
        public override void Configure(EntityTypeBuilder<ConfigGenericGroup> builder)
        {
            builder.ToTable("ConfigGenericGroups");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Code)
                .HasMaxLength(64);

            builder.Property(x => x.RelatedSubject)
                .HasMaxLength(64);

            builder.Property(x => x.Description)
                .HasMaxLength(512);

            builder.HasData(ConfigGenericGroupDataSeeding.GetData());

            base.Configure(builder);
        }
    }
}
