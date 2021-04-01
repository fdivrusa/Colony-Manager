using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ConfigGenericItem : BaseEntity
    {
        public ConfigGenericItem()
        {
            ConfigGenericItemExtensions = new List<ConfigGenericItemExtension>();
            AddressTypes = new List<PeopleAddress>();
        }

        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ConfigGenericGroup ConfigGenericGroup { get; set; }
        public virtual People PeopleGender { get; set; }
        public virtual People PeopleProfession { get; set; }

        public virtual ICollection<ConfigGenericItemExtension> ConfigGenericItemExtensions { get; set; }
        public virtual ICollection<PeopleAddress> AddressTypes { get; set; }
        public virtual ICollection<PeopleInternetInformation> PeopleInternetInformations { get; set; }
        public virtual ICollection<PeoplePhoneInformation> PeoplePhoneInformations { get; set; }
    }
}