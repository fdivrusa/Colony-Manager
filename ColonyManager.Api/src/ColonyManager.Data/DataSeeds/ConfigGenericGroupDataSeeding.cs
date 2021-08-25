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
                },

                new ConfigGenericGroup
                {
                    Id= 2,
                    Code = "COUNTRIES",
                    Description = "Group that contains all the known countries",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed",
                    RelatedSubject = "PEOPLES"
                },

                new ConfigGenericGroup
                {
                    Id= 3,
                    Code = "LANGUAGES",
                    Description = "Group that contains all the known Languages",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed",
                    RelatedSubject = "PEOPLES"
                }
            };
        }
    }
}
