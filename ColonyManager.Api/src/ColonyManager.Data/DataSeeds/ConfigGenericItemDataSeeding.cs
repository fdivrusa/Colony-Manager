using ColonyManager.Data.Entities;
using System;

namespace ColonyManager.Data.DataSeeds
{
    public static class ConfigGenericItemDataSeeding
    {
        public static ConfigGenericItem[] GetData()
        {
            return new ConfigGenericItem[]
            {
                new ConfigGenericItem
                {
                    Id = 0,
                    GroupId = 1,
                    Code = "UNK",
                    Description = "Unknown",
                    CreatedDate = new DateTime(2021, 12, 31),
                    LastUpdatedUserName = "SYSTEM",
                    Comment = "Initial seed"
                }
            };
        }
    }
}
