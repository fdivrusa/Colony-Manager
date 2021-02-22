using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IConfigGenericItemService
    {
        /// <summary>
        /// Get config generic item by group id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<ConfigGenericItemDto>> GetConfigGenericItemByGroupIdAsync(int id);

        /// <summary>
        /// Get config generic item by group code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        Task<IEnumerable<ConfigGenericItemDto>> GetConfigGenericItemByGroupCodeAsync(string code);

        /// <summary>
        /// Get specific config generic item by groups and item code
        /// </summary>
        /// <param name="groupCode"></param>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        Task<ConfigGenericItemDto> GetConfigGenericItemByCodesAsync(string groupCode, string itemCode);

        /// <summary>
        /// Add new config generic item
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ConfigGenericItemDto> AddNewConfigGenericItemAsync(AddConfigGenericItemRequestDto request, string userName);

        /// <summary>
        /// Delete a config generic item
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task DeleteConfigGenericItemAsync(DeleteConfigGenericItemDto request);

        /// <summary>
        /// Update existing config generic item
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ConfigGenericItemDto> UpdateConfigGenericItemDto(UpdateConfigGenericItemRequestDto request, string userName);

    }
}
