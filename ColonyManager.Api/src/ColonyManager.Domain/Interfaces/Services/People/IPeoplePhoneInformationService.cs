using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IPeoplePhoneInformationService
    {
        /// <summary>
        /// Get all the phones information of a specific people
        /// </summary>
        /// <param name="peopleId"></param>
        /// <returns></returns>
        Task<IEnumerable<PeoplePhoneInformationDto>> GetPeoplePhoneInformationsAsync(int peopleId);

        /// <summary>
        /// Add new people phone
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeoplePhoneInformationDto> AddPeoplePhoneInformationAsync(AddPeoplePhoneRequestDto request, string userName);

        /// <summary>
        /// Update existing phone
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeoplePhoneInformationDto> UpdatePeoplePhoneInformationAsync(UpdatePeoplePhoneRequestDto request, string userName);
    }
}
