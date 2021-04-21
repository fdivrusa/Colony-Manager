using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ColonyBuildingConfiguration : BaseConfiguration<ColonyBuilding>
    {
        public override void Configure(EntityTypeBuilder<ColonyBuilding> builder)
        {
            builder.ToTable("ColonyBuildings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x => x.Colony)
                .WithMany(x => x.ColonyBuildings)
                .HasForeignKey(x => x.ColonyId)
                .HasConstraintName("FK_ColonyBuilding_Colony")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.ColonyBuidingType)
                .WithMany(x => x.ColonyBuildings)
                .HasForeignKey(x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId })
                .HasConstraintName("FK_ColonyBuilding_ConfigGenericItem");

            base.Configure(builder);
        }
    }
}
