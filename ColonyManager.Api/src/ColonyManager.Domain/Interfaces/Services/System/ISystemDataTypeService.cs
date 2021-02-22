using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface ISystemDataTypeService
    {
        /// <summary>
        /// Get all the system data types
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SystemDataTypeDto>> GetAllSystemDataTypesAsync();

        /// <summary>
        /// Add new system data type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<SystemDataTypeDto> AddSystemDataTypeAsync(AddSystemDataTypeRequestDto request, string userName);

        /// <summary>
        /// Update existing system data type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<SystemDataTypeDto> UpdateSystemDataTypeAsync(UpdateSystemDataTypeRequestDto request, string userName);
    }
}
