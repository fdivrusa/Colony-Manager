using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PeopleConfiguration : BaseConfiguration<People>
    {
        public override void Configure(EntityTypeBuilder<People> builder)
        {

            builder.ToTable("Peoples");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.LastName).HasMaxLength(64);
            builder.Property(x => x.FirstName).HasMaxLength(64);

            builder.HasOne(x => x.Gender)
                .WithOne(x => x.PeopleGender)
                .HasForeignKey<People>(x => new { x.ConfigGenericGenderGroupId, x.ConfigGenericGenderId })
                .HasConstraintName("FK_People_ConfigGenericItem_Gender")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Profession)
                .WithOne(x => x.PeopleProfession)
                .HasForeignKey<People>(x => new { x.ConfigGenericProfessionGroupId, x.ConfigGenericProfessionId })
                .HasConstraintName("FK_People_ConfigGenericItem_Profession")
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
