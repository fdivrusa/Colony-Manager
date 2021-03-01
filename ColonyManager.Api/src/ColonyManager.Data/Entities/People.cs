using System;

namespace ColonyManager.Data.Entities
{
    public class People : BaseEntity
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ConfigGenericGenderGroupId { get; set; }
        public int? ConfigGenericGenderId { get; set; }
        public int? ConfigGenericProfessionGroupId { get; set; }
        public int? ConfigGenericProfessionId { get; set; }

        public virtual ConfigGenericItem Gender { get; set; }
        public virtual ConfigGenericItem Profession { get; set; }
    }
}
