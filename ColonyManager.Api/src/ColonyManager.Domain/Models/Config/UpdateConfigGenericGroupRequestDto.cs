using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models.Config
{
    public class UpdateConfigGenericGroupRequestDto
    {
        public int GroupId { get; set; }
        public string Description { get; set; }
    }
}
