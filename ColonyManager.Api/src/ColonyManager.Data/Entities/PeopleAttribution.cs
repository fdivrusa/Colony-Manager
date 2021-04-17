using System;

namespace ColonyManager.Data.Entities
{
    public class PeopleAttribution : BaseEntity
    {
        public int PeopleId { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remarks { get; set; }

        public virtual People People { get; set; }
        public virtual ConfigGenericItem AttributionType { get; set; }
    }
}
