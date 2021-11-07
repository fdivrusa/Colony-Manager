using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ColonyBuildingRoomConfiguration : BaseConfiguration<ColonyBuildingRoom>
    {
        public override void Configure(EntityTypeBuilder<ColonyBuildingRoom> builder)
        {
            builder.ToTable("ColonyBuildingRooms");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x => x.ColonyBuilding)
                .WithMany(x => x.ColonyBuildingRooms)
                .HasForeignKey(x => x.ColonyBuildingId)
                .HasConstraintName("FK_ColonyBuildingRoom_ColonyBuilding")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.ColonyBuildingRoomType)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => new { x.ColonyBuildingId })
                .HasConstraintName("FK_ColonyBuildingRoom_RoomType");

            base.Configure(builder);
        }
    }
}
