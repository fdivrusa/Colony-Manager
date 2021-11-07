using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class RoomType : ConfigBaseEntity
    {
        public RoomType()
        {
            Rooms = new List<ColonyBuildingRoom>();
        }

        public ICollection<ColonyBuildingRoom> Rooms { get; set; }
    }
}
