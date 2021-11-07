using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class PhoneInformationTypeConfiguration : ConfigBaseConfiguration<PhoneInformationType>
    {
        public override void Configure(EntityTypeBuilder<PhoneInformationType> builder)
        {
            builder.ToTable("PhoneInformationTypes");
            base.Configure(builder);
        }
    }
}
