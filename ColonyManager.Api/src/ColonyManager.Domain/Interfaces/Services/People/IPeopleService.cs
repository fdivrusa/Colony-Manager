using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IPeopleService
    {
        /// <summary>
        /// Return all the peoples  
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PeopleDetailedDto>> GetAllPeoplesAsync();

        /// <summary>
        /// Add new people
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleDetailedDto> AddPeopleAsync(AddPeopleRequestDto request, string userName);

        /// <summary>
        /// Update existing people
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleDetailedDto> UpdatePeopleAsync(UpdatePeopleRequestDto request, string userName);
    }


}
