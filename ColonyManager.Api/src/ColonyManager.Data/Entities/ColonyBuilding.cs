using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ColonyBuilding : BaseEntity
    {
        public ColonyBuilding()
        {
            ColonyBuildingRooms = new List<ColonyBuildingRoom>();
        }

        public int ColonyId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public Point Location { get; set; }

        public virtual Colony Colony { get; set; }
        public virtual ConfigGenericItem ColonyBuidingType { get; set; }
        public virtual ICollection<ColonyBuildingRoom> ColonyBuildingRooms { get; set; }
    }
}
