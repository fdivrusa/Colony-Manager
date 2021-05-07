using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Colony : BaseEntity
    {
        public Colony()
        {
            ColonyBuildings = new List<ColonyBuilding>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public int MaxPopulation { get; set; }
        public int ActualPopulation { get; set; }
        public Geometry Border { get; set; }

        public virtual ConfigGenericItem ColonyType { get; set; }
        public virtual ICollection<ColonyBuilding> ColonyBuildings { get; set; }
    }
}
