using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Config
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigGenericItemExtentionValuesController : BaseController
    {
        private readonly IConfigGenericItemExtentionValueService _configGenericItemExtentionValueService;

        public ConfigGenericItemExtentionValuesController(IConfigGenericItemExtentionValueService configGenericItemExtentionValueService)
        {
            _configGenericItemExtentionValueService = configGenericItemExtentionValueService;
        }

        [HttpPost]
        public async Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync(AddConfigGenericItemExtentionValueRequestDto request)
        {
            return await _configGenericItemExtentionValueService.AddConfigGenericItemExtentionValueAsync(request, Account?.FullName);
        }
    }
}
