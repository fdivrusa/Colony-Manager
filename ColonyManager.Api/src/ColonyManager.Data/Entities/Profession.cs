using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Profession : ParamConfigBaseEntity
    {
        public Profession()
        {
            Peoples = new List<People>();
        }

        public ICollection<People> Peoples { get; set; }
    }
}
