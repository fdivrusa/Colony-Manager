namespace ColonyManager.Domain.Models
{
    public class AddPeopleAddressRequestDto
    {
        public int PeopleId { get; set; }
        public int AddressTypeId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public int? Box { get; set; }
        public int Number { get; set; }
        public int CountryId { get; set; }
    }
}
