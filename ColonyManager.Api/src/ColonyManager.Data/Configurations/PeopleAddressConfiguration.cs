using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PeopleAddressConfiguration : BaseConfiguration<PeopleAddress>
    {
        public override void Configure(EntityTypeBuilder<PeopleAddress> builder)
        {
            builder.ToTable("PeopleAddresses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.City).HasMaxLength(64);
            builder.Property(x => x.StreetName).HasMaxLength(64);
            builder.Property(x => x.Area).HasMaxLength(64);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CountryId)
                .HasConstraintName("FK_PeopleAddress_Country");

            builder.HasOne(x => x.Type)
                .WithMany(x => x.AddressTypes)
                .HasForeignKey(x => new { x.ConfigGenericTypeGroupId, x.ConfigGenericTypeId })
                .HasConstraintName("FK_PeopleAddress_Type");

            base.Configure(builder);
        }
    }
}
