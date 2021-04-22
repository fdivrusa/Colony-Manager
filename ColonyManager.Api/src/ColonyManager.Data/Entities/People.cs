using System;
using System.Collections.Generic;

namespace ColonyManager.Data.Entities
{
    public class People : BaseEntity
    {
        public People()
        {
            Addresses = new List<PeopleAddress>();
            PhoneInformations = new List<PeoplePhoneInformation>();
            InternetInformations = new List<PeopleInternetInformation>();
            PeopleAttributions = new List<PeopleAttribution>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ConfigGenericGenderGroupId { get; set; }
        public int? ConfigGenericGenderId { get; set; }
        public int? ConfigGenericProfessionGroupId { get; set; }
        public int? ConfigGenericProfessionId { get; set; }
        public int? ConfigGenericNationalityGroupId { get; set; }
        public int? ConfigGenericNationalityId { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public virtual ConfigGenericItem Gender { get; set; }
        public virtual ConfigGenericItem Profession { get; set; }
        public virtual ConfigGenericItem Nationality { get; set; }

        public virtual ICollection<PeopleAddress> Addresses { get; set; }
        public virtual ICollection<PeoplePhoneInformation> PhoneInformations { get; set; }
        public virtual ICollection<PeopleInternetInformation> InternetInformations { get; set; }
        public virtual ICollection<PeopleAttribution> PeopleAttributions { get; set; }
    }
}
