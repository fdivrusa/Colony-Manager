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
        Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroupsAsync();

        /// <summary>
        /// Get generic groups by related subject
        /// </summary>
        /// <param name="relatedSubject">The related subject</param>
        /// <returns></returns>
        Task<IEnumerable<ConfigGenericGroupDto>> GetGenericGroupsByRelatedSubjectAsync(string relatedSubject);

        /// <summary>
        /// Get detailed group by Id
        /// </summary>
        /// <param name="Id">The group Id</param>
        /// <returns></returns>
        Task<ConfigGenericGroupDetailedDto> GetGenericGroupByIdAsync(int Id);

        /// <summary>
        /// Get detailed group by code
        /// </summary>
        /// <param name="code">The group code</param>
        /// <returns></returns>
        Task<ConfigGenericGroupDetailedDto> GetGenericGroupByCodeAsync(string code);

        /// <summary>
        /// Add new config generic group
        /// </summary>
        /// <param name="request">Request to add new config generic group</param>
        /// <returns></returns>
        Task<ConfigGenericGroupDto> AddNewConfigGenericGroupAsync(AddConfigGenericGroupDto request, string userName);

        /// <summary>
        /// Update config generic group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<ConfigGenericGroupDto> UpdateConfigGenericGroupAsync(UpdateConfigGenericGroupRequestDto request, string userName);
    }
}
