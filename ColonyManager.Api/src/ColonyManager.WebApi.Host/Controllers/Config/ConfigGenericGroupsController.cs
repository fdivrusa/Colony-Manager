using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Config
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigGenericGroupsController : BaseController
    {
        private readonly IConfigGenericGroupService _configGenericGroupService;

        public ConfigGenericGroupsController(IConfigGenericGroupService configGenericGroupService)
        {
            _configGenericGroupService = configGenericGroupService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroups()
        {
            return await _configGenericGroupService.GetAllGenericGroups();
        }
    }
}
