using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class InternetInformationType : ConfigBaseEntity
    {
        public InternetInformationType()
        {
            PeopleInternetInformations = new List<PeopleInternetInformation>();
        }

        public ICollection<PeopleInternetInformation> PeopleInternetInformations { get; set; }
    }
}
