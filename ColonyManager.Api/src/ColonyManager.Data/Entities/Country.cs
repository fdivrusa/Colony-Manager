using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class Country
    {
        public Country()
        {
            Addresses = new List<PeopleAddress>();
        }

        public int Id { get; set; }
        public string AlphaCode2 { get; set; }
        public string AlphaCode3 { get; set; }
        public string Description { get; set; }
        public string NumericCode { get; set; }

        public virtual ICollection<PeopleAddress> Addresses { get; set; }
    }
}
