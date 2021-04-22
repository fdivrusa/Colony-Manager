using ColonyManager.Data.DataSeeds;
using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ConfigGenericItemConfiguration : BaseConfiguration<ConfigGenericItem>
    {
        public override void Configure(EntityTypeBuilder<ConfigGenericItem> builder)
        {
            builder.ToTable("ConfigGenericItems");
            builder.HasKey(x => new { x.GroupId, x.Id });

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Code)
                .HasMaxLength(64);

            builder.Property(x => x.Description)
                .HasMaxLength(512);

            builder.HasOne(x => x.ConfigGenericGroup)
                .WithMany(x => x.ConfigGenericItems)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfigGenericItems_ConfigGenericGroups");

            builder.HasData(ConfigGenericItemDataSeeding.GetData());

            base.Configure(builder);
        }
    }
}
