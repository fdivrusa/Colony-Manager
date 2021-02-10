using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IConfigGenericGroupService
    {
        /// <summary>
        /// Get all the non detailed groups of the database
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroups();
    }
}
