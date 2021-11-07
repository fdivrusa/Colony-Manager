using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class BuildingType : ConfigBaseEntity
    {
        public BuildingType()
        {
            Buildings = new List<ColonyBuilding>();
        }

        public ICollection<ColonyBuilding> Buildings { get; set; }
    }
}
