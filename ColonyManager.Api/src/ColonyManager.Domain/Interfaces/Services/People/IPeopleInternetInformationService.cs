using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IPeopleInternetInformationService
    {
        /// <summary>
        /// Get the people internet informations of a people
        /// </summary>
        /// <param name="peopleId"></param>
        /// <returns></returns>
        Task<IEnumerable<PeopleInternetInformationDto>> GetPeopleInternetInformationsAsync(int peopleId);

        /// <summary>
        /// Add new people internet information
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleInternetInformationDto> AddPeopleInternetInformationAsync(AddPeopleInternetInformationRequestDto request, string userName);

        /// <summary>
        /// Update existing people internet information
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleInternetInformationDto> UpdatePeopleInternetInformationAsync(UpdatePeopleInternetInformationRequestDto request, string userName);
    }
}
