using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ConfigGenericItem : BaseEntity
    {
        public ConfigGenericItem()
        {
            ConfigGenericItemExtensions = new List<ConfigGenericItemExtension>();
            Addresses = new List<PeopleAddress>();
            PeopleAttributions = new List<PeopleAttribution>();
            PeopleInternetInformations = new List<PeopleInternetInformation>();
            PeoplePhoneInformations = new List<PeoplePhoneInformation>();
            PeopleGenders = new List<People>();
            PeopleProfessions = new List<People>();
            PeopleNationalities = new List<People>();
            Colonies = new List<Colony>();
            ColonyBuildings = new List<ColonyBuilding>();
            ColonyBuildingRooms = new List<ColonyBuildingRoom>();
        }

        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ConfigGenericGroup ConfigGenericGroup { get; set; }

        public virtual ICollection<People> PeopleGenders { get; set; }
        public virtual ICollection<People> PeopleProfessions { get; set; }
        public virtual ICollection<People> PeopleNationalities { get; set; }
        public virtual ICollection<ConfigGenericItemExtension> ConfigGenericItemExtensions { get; set; }
        public virtual ICollection<PeopleAddress> Addresses { get; set; }
        public virtual ICollection<PeopleInternetInformation> PeopleInternetInformations { get; set; }
        public virtual ICollection<PeoplePhoneInformation> PeoplePhoneInformations { get; set; }
        public virtual ICollection<PeopleAttribution> PeopleAttributions { get; set; }
        public virtual ICollection<Colony> Colonies { get; set; }
        public virtual ICollection<ColonyBuilding> ColonyBuildings { get; set; }
        public virtual ICollection<ColonyBuildingRoom> ColonyBuildingRooms { get; set; }
    }
}