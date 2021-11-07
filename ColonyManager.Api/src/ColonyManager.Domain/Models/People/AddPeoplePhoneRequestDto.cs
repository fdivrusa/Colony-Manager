namespace ColonyManager.Domain.Models
{
    public class AddPeoplePhoneRequestDto
    {
        public int PeopleId { get; set; }
        public int PhoneTypeId { get; set; }
        public string Value { get; set; }
    }
}
