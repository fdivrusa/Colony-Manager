using System;

namespace ColonyManager.Data.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public string Comment { get; set; }
    }
}
