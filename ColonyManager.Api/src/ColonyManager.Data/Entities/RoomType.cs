using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class RoomType : ParamConfigBaseEntity
    {
        public RoomType()
        {
            Rooms = new List<ColonyBuildingRoom>();
        }

        public ICollection<ColonyBuildingRoom> Rooms { get; set; }
    }
}
