using System;
using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class People : BaseEntity
    {
        public People()
        {
            Addresses = new List<PeopleAddress>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ConfigGenericGenderGroupId { get; set; }
        public int? ConfigGenericGenderId { get; set; }
        public int? ConfigGenericProfessionGroupId { get; set; }
        public int? ConfigGenericProfessionId { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public virtual ConfigGenericItem Gender { get; set; }
        public virtual ConfigGenericItem Profession { get; set; }

        public virtual ICollection<PeopleAddress> Addresses { get; set; }
    }
}
