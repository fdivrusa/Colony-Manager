using ColonyManager.Core.Models.Responses;
using System.Threading.Tasks;

namespace ColonyManager.Core.Services.Interfaces
{
    public interface IPeopleService
    {
        /// <summary>
        /// Get all peoples
        /// </summary>
        /// <returns></returns>
        Task<GetPeoplesResponse> GetPeoplesList();
    }
}
