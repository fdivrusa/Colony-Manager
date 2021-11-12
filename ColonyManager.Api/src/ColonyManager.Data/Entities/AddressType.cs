using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class AddressType : ParamConfigBaseEntity
    {
        public AddressType()
        {
            PeoplesAdresses = new List<PeopleAddress>();
        }

        public ICollection<PeopleAddress> PeoplesAdresses { get; set; }
    }
}
