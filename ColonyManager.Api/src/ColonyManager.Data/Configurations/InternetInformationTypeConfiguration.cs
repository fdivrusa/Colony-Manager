using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class InternetInformationTypeConfiguration : ConfigBaseConfiguration<InternetInformationType>
    {
        public override void Configure(EntityTypeBuilder<InternetInformationType> builder)
        {
            builder.ToTable("InternetInformationTypes");
            base.Configure(builder);
        }
    }
}
