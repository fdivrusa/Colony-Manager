using ColonyManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColonyManager.Data.Configurations
{
    public class ProfessionConfiguration : ConfigBaseConfiguration<Profession>
    {
        public override void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.ToTable("Professions");
            base.Configure(builder);
        }
    }
}
