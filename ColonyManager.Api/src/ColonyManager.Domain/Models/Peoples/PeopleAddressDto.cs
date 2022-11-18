namespace ColonyManager.Domain.Models
{
    public class PeopleAddressDto : BaseDto
    {
        public int PeopleId { get; set; }
        public string CountryCode { get; set; }
        public string CountryDescription { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeDescription { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public int? Box { get; set; }
        public int Number { get; set; }
    }
}
