using System;

namespace ColonyManager.Domain.Models
{
    public class AddPeopleRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public int? ProfessionId { get; set; }
        public int? NationalityId { get; set; }
    }
}
