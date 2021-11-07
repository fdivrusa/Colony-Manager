using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class AttributionType : ConfigBaseEntity
    {
        public AttributionType()
        {
            PeopleAttributions = new List<PeopleAttribution>();
        }

        public ICollection<PeopleAttribution> PeopleAttributions { get; set; }
    }
}
