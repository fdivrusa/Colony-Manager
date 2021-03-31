using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ConfigGenericGroup : BaseEntity
    {
        public string RelatedSubject { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ConfigGenericItem> ConfigGenericItems { get; set; }
    }
}
