using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ConfigBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : ConfigBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(128);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.Comment).HasMaxLength(512);
            builder.Property(x => x.LastUpdatedUserName).HasMaxLength(128);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
