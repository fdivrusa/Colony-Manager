namespace ColonyManager.Domain.Models
{
    public class UpdatePeopleInternetInformationRequestDto
    {
        public int Id { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public string Value { get; set; }
        public bool IsObsolete { get; set; }
        public string Comment { get; set; }
    }
}
