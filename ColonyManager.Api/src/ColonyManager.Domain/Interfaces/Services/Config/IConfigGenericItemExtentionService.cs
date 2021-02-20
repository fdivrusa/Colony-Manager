using ColonyManager.Domain.Models;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IConfigGenericItemExtentionService
    {

        /// <summary>
        /// Add new config generic item extention
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<ConfigGenericItemExtentionDto> AddConfigGenericItemExtentionAsync(AddConfigGenericItemExtentionRequestDto request, string userName);

        /// <summary>
        /// Update config generic item extention
        /// </summary>
        /// <returns></returns>
        Task<ConfigGenericItemExtentionDto> UpdateConfigGenericItemExtentionAsync(UpdateConfigGenericItemExtentionRequestDto request, string userName);

        /// <summary>
        /// Delete config generic item extention
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task DeleteConfigGenericItemExtentionAsync(ConfigGenericItemExtentionDto request);
    }
}
