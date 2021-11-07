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
                .WithMany(x => x.Peoples)
                .HasForeignKey(x => new { x.GenderTypeId })
                .HasConstraintName("FK_People_GenderType")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Profession)
                .WithMany(x => x.Peoples)
                .HasForeignKey(x => new { x.ProfessionTypeId })
                .HasConstraintName("FK_People_ProfessionType")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Nationality)
                .WithMany(x => x.Peoples)
                .HasForeignKey(x => new { x.NationalityId })
                .HasConstraintName("FK_People_Nationality")
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
