using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Gender : ParamConfigBaseEntity
    {
        public Gender()
        {
            Peoples = new List<People>();
        }

        public ICollection<People> Peoples { get; set; }
    }
}
