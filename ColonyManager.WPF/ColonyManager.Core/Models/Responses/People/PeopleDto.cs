using System;

namespace ColonyManager.Core.Models.Responses
{
    public class PeopleDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ConfigGenericGenderGroupId { get; set; }
        public int? ConfigGenericGenderId { get; set; }
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
        public int? ConfigGenericProfessionGroupId { get; set; }
        public int? ConfigGenericProfessionId { get; set; }
        public string ProfessionCode { get; set; }
        public string ProfessionDescription { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
    }
}
