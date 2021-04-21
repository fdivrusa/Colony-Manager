using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ColonyConfiguration : BaseConfiguration<Colony>
    {
        public override void Configure(EntityTypeBuilder<Colony> builder)
        {

            builder.ToTable("Colonies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasMany(x => x.ColonyBuildings)
                .WithOne(x => x.Colony)
                .HasForeignKey(x => x.ColonyId)
                .HasConstraintName("FK_Colony_ColonyBuilding")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.ColonyType)
                .WithMany(x => x.Colonies)
                .HasForeignKey(x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId })
                .HasConstraintName("FK_Colony_ConfigGenericItem")
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
