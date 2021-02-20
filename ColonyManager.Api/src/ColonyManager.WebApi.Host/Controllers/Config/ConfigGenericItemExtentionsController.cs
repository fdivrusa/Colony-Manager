using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Config
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigGenericItemExtentionsController : BaseController
    {
        private readonly IConfigGenericItemExtentionService _configGenericItemExtentionService;

        public ConfigGenericItemExtentionsController(IConfigGenericItemExtentionService configGenericItemExtentionService)
        {
            _configGenericItemExtentionService = configGenericItemExtentionService;
        }

        [HttpPost]
        public async Task<ConfigGenericItemExtentionDto> AddConfigGenericItemExtentionDtoAsync(AddConfigGenericItemExtentionRequestDto request)
        {
            return await _configGenericItemExtentionService.AddConfigGenericItemExtentionAsync(request, Account?.FullName);
        }

        [HttpDelete]
        public async Task DeleteConfigGenericItemExtentionAsync(ConfigGenericItemExtentionDto request)
        {
            await _configGenericItemExtentionService.DeleteConfigGenericItemExtentionAsync(request);
        }

        [HttpPut]
        public async Task<ConfigGenericItemExtentionDto> UpdateConfigGenericItemExtentionDtoAsync(UpdateConfigGenericItemExtentionRequestDto request)
        {
            return await _configGenericItemExtentionService.UpdateConfigGenericItemExtentionAsync(request, Account?.FullName);
        }
    }
}
