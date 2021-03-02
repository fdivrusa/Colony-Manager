using ColonyManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IPeopleService
    {
        /// <summary>
        /// Return all the peoples  
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PeopleDto>> GetAllPeoplesAsync();

        /// <summary>
        /// Add new people
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleDto> AddPeopleAsync(AddPeopleRequestDto request, string userName);

        /// <summary>
        /// Update existing people
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<PeopleDto> UpdatePeopleAsync(UpdatePeopleRequestDto request, string userName);
    }


}
