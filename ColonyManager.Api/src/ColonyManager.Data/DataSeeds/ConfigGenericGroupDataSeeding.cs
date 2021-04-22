using ColonyManager.Data.Entities;
using System;

namespace ColonyManager.Data.DataSeeds
{
    public static class ConfigGenericGroupDataSeeding
    {
        public static ConfigGenericGroup[] GetData()
        {
            return new ConfigGenericGroup[]
            {
                new ConfigGenericGroup
                {
                    Id = 1,
                    Code = "NATIONALITIES",
                    Description = "Group that contains all the known nationalities",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed",
                    RelatedSubject = "PEOPLES"
                }
            };
        }
    }
}
