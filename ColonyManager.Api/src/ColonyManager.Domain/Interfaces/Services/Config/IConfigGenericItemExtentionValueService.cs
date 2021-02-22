using ColonyManager.Domain.Models;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IConfigGenericItemExtentionValueService
    {
        /// <summary>
        /// Add new config generic item extention value
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync(AddConfigGenericItemExtentionValueRequestDto request, string userName);

        /// <summary>
        /// Update existing config generic item extention value
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<ConfigGenericItemExtentionValueDto> UpdateConfigGenericItemExtentionValueAsync(UpdateConfigGenericItemExtentionValueRequestDto request, string userName);

        /// <summary>
        /// Delete existing config generic item extention value
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task DeleteConfigGenericItemExtentionValueAsync(ConfigGenericItemExtentionValueDto request);
    }
}
