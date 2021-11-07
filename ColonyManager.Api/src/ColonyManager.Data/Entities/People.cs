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
        public int GenderTypeId { get; set; }
        public int? ProfessionTypeId { get; set; }
        public int NationalityId { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual Nationality Nationality { get; set; }

        public virtual ICollection<PeopleAddress> Addresses { get; set; }
        public virtual ICollection<PeoplePhoneInformation> PhoneInformations { get; set; }
        public virtual ICollection<PeopleInternetInformation> InternetInformations { get; set; }
        public virtual ICollection<PeopleAttribution> PeopleAttributions { get; set; }
    }
}
