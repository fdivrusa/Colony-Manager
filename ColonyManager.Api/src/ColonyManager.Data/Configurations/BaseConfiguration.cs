using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Comment).HasMaxLength(512);
            builder.Property(x => x.LastUpdatedUserName).HasMaxLength(128);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
