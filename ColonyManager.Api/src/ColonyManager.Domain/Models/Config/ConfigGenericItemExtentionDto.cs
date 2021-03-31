using System.Collections.Generic;

namespace ColonyManager.Domain.Models
{
    public class ConfigGenericItemExtentionDto : BaseDto
    {
        public int ItemId { get; set; }
        public int GroupId { get; set; }
        public int SystemDataTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<ConfigGenericItemExtentionValueDto> ConfigGenericItemExtentionValues { get; set; }
    }
}