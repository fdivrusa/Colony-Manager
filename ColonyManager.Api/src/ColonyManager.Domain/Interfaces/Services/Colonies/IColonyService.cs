using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IColonyService
    {
        /// <summary>
        /// Get all colonies in database
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ColonyDto>> GetAllColoniesAsync();

        /// <summary>
        /// Add new colony in database
        /// </summary>
        /// <param name="request"></param>
        /// <param name="fullName"></param>
        /// <returns></returns>
        Task<ColonyDto> AddColonyAsync(AddColonyRequestDto request, string fullName);
    }
}
