namespace ColonyManager.Domain.Models
{
    public class UpdatePeoplePhoneRequestDto
    {
        public int Id { get; set; }
        public int PhoneTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }
        public string Comment { get; set; }
    }
}
