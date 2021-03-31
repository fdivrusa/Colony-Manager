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
    }
}
