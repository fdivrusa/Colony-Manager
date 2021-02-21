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
        public async Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync([FromBody] AddConfigGenericItemExtentionValueRequestDto request)
        {
            return await _configGenericItemExtentionValueService.AddConfigGenericItemExtentionValueAsync(request, Account?.FullName);
        }

        [HttpPut]
        public async Task<ConfigGenericItemExtentionValueDto> UpdateConfigGenericItemExtentionValueAsync([FromBody] UpdateConfigGenericItemExtentionValueRequestDto request)
        {
            return await _configGenericItemExtentionValueService.UpdateConfigGenericItemExtentionValueAsync(request, Account?.FullName);
        }

        [HttpDelete]
        public async Task DeleteConfigGenericItemExtentionValueAsync([FromBody] ConfigGenericItemExtentionValueDto request)
        {
            await _configGenericItemExtentionValueService.DeleteConfigGenericItemExtentionValueAsync(request);
        }
    }
}
