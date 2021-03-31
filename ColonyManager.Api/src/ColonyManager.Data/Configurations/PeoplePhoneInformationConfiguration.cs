using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PeoplePhoneInformationConfiguration : BaseConfiguration<PeoplePhoneInformation>
    {
        public override void Configure(EntityTypeBuilder<PeoplePhoneInformation> builder)
        {
            builder.ToTable("PeoplesPhoneInformations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Value).HasMaxLength(256);

            builder.HasOne(x => x.People)
                .WithMany(x => x.PhoneInformations)
                .HasForeignKey(x => x.PeopleId)
                .HasConstraintName("FK_PeoplePhoneInformation_People");

            base.Configure(builder);
        }
    }
}
