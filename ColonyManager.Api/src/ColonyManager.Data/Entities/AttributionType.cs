using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class AttributionType : ParamConfigBaseEntity
    {
        public AttributionType()
        {
            PeopleAttributions = new List<PeopleAttribution>();
        }

        public ICollection<PeopleAttribution> PeopleAttributions { get; set; }
    }
}
