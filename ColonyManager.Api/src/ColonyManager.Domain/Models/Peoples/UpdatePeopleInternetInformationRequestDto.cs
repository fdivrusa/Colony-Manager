namespace ColonyManager.Domain.Models
{
    public class UpdatePeopleInternetInformationRequestDto
    {
        public int Id { get; set; }
        public int InternetInformationTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }
        public string Comment { get; set; }
    }
}
