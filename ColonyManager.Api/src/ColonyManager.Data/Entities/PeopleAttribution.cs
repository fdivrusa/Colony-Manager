using System;

namespace ColonyManager.Data.Entities
{
    public class PeopleAttribution : BaseEntity
    {
        public int PeopleId { get; set; }
        public int? AttributionTypeId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remarks { get; set; }

        public virtual People People { get; set; }
        public virtual AttributionType AttributionType { get; set; }
    }
}
