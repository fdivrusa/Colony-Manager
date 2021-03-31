using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PeopleInternetInformationConfiguration : BaseConfiguration<PeopleInternetInformation>
    {
        public override void Configure(EntityTypeBuilder<PeopleInternetInformation> builder)
        {
            builder.ToTable("PeoplesInternetInformations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Value).HasMaxLength(256);

            builder.HasOne(x => x.People)
                .WithMany(x => x.InternetInformations)
                .HasForeignKey(x => x.PeopleId)
                .HasConstraintName("FK_PeopleInternetInformation_People");

            base.Configure(builder);
        }
    }
}
