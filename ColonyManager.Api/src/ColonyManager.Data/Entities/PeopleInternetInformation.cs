namespace ColonyManager.Data.Entities
{
    public class PeopleInternetInformation : BaseEntity
    {
        public int PeopleId { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }

        public virtual People People { get; set; }
    }
}
