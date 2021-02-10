using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class SystemDataType : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsList { get; set; }

        public virtual ICollection<ConfigGenericItemExtension> ConfigGenericItemExtensions { get; set; }
    }
}
