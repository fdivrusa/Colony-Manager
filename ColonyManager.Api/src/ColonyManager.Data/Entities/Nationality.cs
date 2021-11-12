using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Nationality : ParamConfigBaseEntity
    {
        public Nationality()
        {
            Peoples = new List<People>();
        }

        public ICollection<People> Peoples { get; set; }
    }
}
