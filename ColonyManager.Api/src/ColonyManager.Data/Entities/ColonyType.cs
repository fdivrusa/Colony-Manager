using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class ColonyType : ParamConfigBaseEntity
    {
        public ColonyType()
        {
            Colonies = new List<Colony>();
        }

        public virtual ICollection<Colony> Colonies { get; set; }
    }
}
