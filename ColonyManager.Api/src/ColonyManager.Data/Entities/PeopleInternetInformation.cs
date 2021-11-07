namespace ColonyManager.Data.Entities
{
    public class PeopleInternetInformation : BaseEntity
    {
        public int PeopleId { get; set; }
        public int InternetInformationTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }

        public virtual People People { get; set; }

        public virtual InternetInformationType Type { get; set; }
    }
}
