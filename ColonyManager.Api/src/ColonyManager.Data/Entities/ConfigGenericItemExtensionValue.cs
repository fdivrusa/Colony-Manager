namespace ColonyManager.Data.Entities
{
    public class ConfigGenericItemExtensionValue : BaseEntity
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int ExtentionId { get; set; }
        public string Value { get; set; }

        public virtual ConfigGenericItemExtension ConfigGenericItemExtension { get; set; }
    }
}