using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PeopleAttributionConfiguration : BaseConfiguration<PeopleAttribution>
    {
        public override void Configure(EntityTypeBuilder<PeopleAttribution> builder)
        {
            builder.ToTable("PeopleAttributions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Remarks).HasMaxLength(2048);

            builder.HasOne(x => x.People)
                .WithMany(x => x.PeopleAttributions)
                .HasForeignKey(x => x.PeopleId)
                .HasConstraintName("FK_PeopleAttributions_Peoples")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.AttributionType)
                .WithMany(x => x.PeopleAttributions)
                .HasForeignKey(x => new { x.AttributionTypeId })
                .HasConstraintName("FK_PeopleAttribution_AttributionType")
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
