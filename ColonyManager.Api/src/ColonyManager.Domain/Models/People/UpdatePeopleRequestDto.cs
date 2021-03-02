using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models
{
    public class UpdatePeopleRequestDto
    {
        public int Id { get; set; }
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
    }
}
