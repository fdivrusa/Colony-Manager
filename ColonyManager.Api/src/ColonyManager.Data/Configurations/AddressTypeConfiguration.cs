using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class AddressTypeConfiguration : BaseConfiguration<AddressType>
    {
        public override void Configure(EntityTypeBuilder<AddressType> builder)
        {
            builder.ToTable("AddressTypes");
            base.Configure(builder);
        }
    }
}
