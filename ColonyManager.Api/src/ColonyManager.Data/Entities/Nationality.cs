using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Nationality : ConfigBaseEntity
    {
        public Nationality()
        {
            Peoples = new List<People>();
        }

        public ICollection<People> Peoples { get; set; }
    }
}
