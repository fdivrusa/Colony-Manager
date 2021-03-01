using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models
{
    public class PeopleDto : BaseDto
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
    }
}
