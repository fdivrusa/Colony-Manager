using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.AlphaCode2).HasMaxLength(2);
            builder.Property(x => x.AlphaCode3).HasMaxLength(3);
            builder.Property(x => x.Description).HasMaxLength(64);
            builder.Property(x => x.NumericCode).HasMaxLength(3);
        }
    }
}
