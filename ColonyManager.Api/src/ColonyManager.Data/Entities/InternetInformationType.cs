using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class InternetInformationType : ParamConfigBaseEntity
    {
        public InternetInformationType()
        {
            PeopleInternetInformations = new List<PeopleInternetInformation>();
        }

        public ICollection<PeopleInternetInformation> PeopleInternetInformations { get; set; }
    }
}
