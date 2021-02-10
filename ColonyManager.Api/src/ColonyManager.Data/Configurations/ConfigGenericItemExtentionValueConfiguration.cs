using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ConfigGenericItemExtentionValueConfiguration : BaseConfiguration<ConfigGenericItemExtensionValue>
    {
        public override void Configure(EntityTypeBuilder<ConfigGenericItemExtensionValue> builder)
        {
            builder.ToTable("ConfigGenericItemExtentionValues");

            builder.HasKey(x => new { x.ItemId, x.GroupId, x.ExtentionId, x.Id });
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Value)
                .HasMaxLength(256);

            builder.HasOne(x => x.ConfigGenericItemExtension)
                .WithMany(x => x.ConfigGenericItemExtensionValues)
                .HasForeignKey(x => new { x.ExtentionId, x.GroupId, x.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfigGenericItemExtentionValues_ConfigGenericItemExtentions");

            base.Configure(builder);
        }
    }
}
