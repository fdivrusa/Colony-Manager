namespace ColonyManager.Data.Entities
{
    public class PeoplePhoneInformation : BaseEntity
    {
        public int PeopleId { get; set; }
        public int PhoneInformationTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }

        public virtual People People { get; set; }
        public virtual PhoneInformationType Type { get; set; }
    }
}
