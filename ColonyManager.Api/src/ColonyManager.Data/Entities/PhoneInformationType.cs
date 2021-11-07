using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class PhoneInformationType : ConfigBaseEntity
    {
        public PhoneInformationType()
        {
            PeoplePhoneInformations = new List<PeoplePhoneInformation>();
        }

        public ICollection<PeoplePhoneInformation> PeoplePhoneInformations { get; set; }
    }
}
