using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Profession : ConfigBaseEntity
    {
        public Profession()
        {
            Peoples = new List<People>();
        }

        public ICollection<People> Peoples  { get; set; }
    }
}
