namespace ColonyManager.Domain.Models
{
    public class PeoplePhoneInformationDto : BaseDto
    {
        public int PeopleId { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }
    }
}
