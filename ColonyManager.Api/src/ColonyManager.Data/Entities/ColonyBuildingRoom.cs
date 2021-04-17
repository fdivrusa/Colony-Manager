namespace ColonyManager.Data.Entities
{
    public class ColonyBuildingRoom : BaseEntity
    {
        public int ColonyBuildingId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ConfigGenericGroupTypeId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public int Floor { get; set; }

        public virtual ColonyBuilding ColonyBuilding { get; set; }
        public virtual ConfigGenericItem ColonyBuildingRoomType { get; set; }
    }
}
