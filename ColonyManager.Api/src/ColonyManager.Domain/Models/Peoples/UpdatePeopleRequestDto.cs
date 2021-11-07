using System;

namespace ColonyManager.Domain.Models
{
    public class UpdatePeopleRequestDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public int ProfessionId { get; set; }
        public int NationalityId { get; set; }
        public bool IsActive { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }
    }
}
