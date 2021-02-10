using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ConfigGenericItem : BaseEntity
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ConfigGenericGroup ConfigGenericGroup { get; set; }
        public virtual ICollection<ConfigGenericItemExtension> ConfigGenericItemExtensions { get; set; }
    }
}