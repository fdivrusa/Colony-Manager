using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ConfigGenericItemExtentionConfiguration : BaseConfiguration<ConfigGenericItemExtension>
    {
        public override void Configure(EntityTypeBuilder<ConfigGenericItemExtension> builder)
        {
            builder.ToTable("ConfigGenericItemExtentions");

            builder.HasKey(x => new { x.GroupId, x.ItemId, x.Id });

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Code)
                .HasMaxLength(64);

            builder.Property(x => x.Description)
                .HasMaxLength(512);

            builder.HasOne(x => x.ConfigGenericItem)
                .WithMany(x => x.ConfigGenericItemExtensions)
                .HasForeignKey(x => new { x.GroupId, x.ItemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfigGenericItemExtentions_ConfigGenericItems");

            builder.HasOne(x => x.SystemDataType)
                .WithMany(x => x.ConfigGenericItemExtensions)
                .HasForeignKey(x => x.SystemDataTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfigGenericItemExtentions_SystemDataTypes");

            base.Configure(builder);

        }
    }
}
