using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface INationalityService
    {
        /// <summary>
        /// Get all nationalities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NationalityDto>> GetAllNationalitiesAsync();
    }
}
