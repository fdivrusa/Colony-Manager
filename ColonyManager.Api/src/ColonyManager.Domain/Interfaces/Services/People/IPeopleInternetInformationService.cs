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
    }
}
