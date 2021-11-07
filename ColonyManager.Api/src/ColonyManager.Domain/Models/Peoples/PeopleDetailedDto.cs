using System;

namespace ColonyManager.Domain.Models
{
    public class PeopleDetailedDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
        public int? ProfessionId { get; set; }
        public string ProfessionCode { get; set; }
        public string ProfessionDescription { get; set; }
        public int NationalityId { get; set; }
        public string NationalityCode { get; set; }
        public string NationalityDescription { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }
    }
}
