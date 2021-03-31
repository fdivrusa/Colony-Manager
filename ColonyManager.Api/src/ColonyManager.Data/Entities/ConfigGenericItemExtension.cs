using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ConfigGenericItemExtension : BaseEntity
    {
        public int ItemId { get; set; }
        public int GroupId { get; set; }
        public int SystemDataTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ConfigGenericItem ConfigGenericItem { get; set; }
        public virtual SystemDataType SystemDataType { get; set; }
        public virtual ICollection<ConfigGenericItemExtensionValue> ConfigGenericItemExtensionValues { get; set; }
    }
}
