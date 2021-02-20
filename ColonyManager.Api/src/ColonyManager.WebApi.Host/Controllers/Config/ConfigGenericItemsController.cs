using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Config
{
    [Route("api/[controller]")]
    public class ConfigGenericItemsController : BaseController
    {
        private readonly IConfigGenericItemService _configGenericItemService;

        public ConfigGenericItemsController(IConfigGenericItemService configGenericItemService)
        {
            _configGenericItemService = configGenericItemService;
        }

        [HttpGet]
        [Route("groupCode/{groupCode}")]
        public async Task<IEnumerable<ConfigGenericItemDto>> GetGenericItemsByGroupCode(string groupCode)
        {
            return await _configGenericItemService.GetConfigGenericItemByGroupCodeAsync(groupCode);
        }

        [HttpGet]
        [Route("groupId/{groupId}")]
        public async Task<IEnumerable<ConfigGenericItemDto>> GetGenericItemsByGroupId(int groupId)
        {
            return await _configGenericItemService.GetConfigGenericItemByGroupIdAsync(groupId);
        }

        [HttpGet]
        [Route("groupCode/{groupCode}/itemCode/{itemCode}")]
        public async Task<ConfigGenericItemDto> GetGenericItemByCodes(string groupCode, string itemCode)
        {
            return await _configGenericItemService.GetConfigGenericItemByCodesAsync(groupCode, itemCode);
        }

        [HttpPost]
        public async Task<ConfigGenericItemDto> AddConfigGenericItemAsync([FromBody] AddConfigGenericItemRequestDto request)
        {
            return await _configGenericItemService.AddNewConfigGenericItemAsync(request, Account?.FullName);
        }

        [HttpDelete]
        public async Task DeleteConfigGenericItemAsync([FromBody] DeleteConfigGenericItemDto request)
        {
            await _configGenericItemService.DeleteConfigGenericItemAsync(request);
        }

        [HttpPut]
        public async Task<ConfigGenericItemDto> UpdateConfigGenericItemAsync([FromBody] UpdateConfigGenericItemRequestDto request)
        {
            return await _configGenericItemService.UpdateConfigGenericItemDto(request, Account?.FullName);
        }
    }
}
