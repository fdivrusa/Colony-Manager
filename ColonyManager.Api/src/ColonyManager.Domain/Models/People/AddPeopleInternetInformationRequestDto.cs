namespace ColonyManager.Domain.Models
{
    public class AddPeopleInternetInformationRequestDto
    {
        public int PeopleId { get; set; }
        public int InternetInformationTypeId { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
    }
}
