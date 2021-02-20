using System.Collections.Generic;

namespace ColonyManager.Domain.Models
{
    public class ConfigGenericGroupDetailedDto : ConfigGenericGroupDto
    {
        public ICollection<ConfigGenericItemDto> ConfigGenericItems { get; set; }
    }
}
