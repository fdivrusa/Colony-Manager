namespace ColonyManager.Domain.Models
{
    public class AddPeoplePhoneRequestDto
    {
        public int PeopleId { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public string Value { get; set; }
    }
}
