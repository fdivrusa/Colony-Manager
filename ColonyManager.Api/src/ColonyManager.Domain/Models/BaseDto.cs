using System;

namespace ColonyManager.Domain.Models
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public string Comment { get; set; }
    }
}
