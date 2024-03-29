﻿using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface INationalityService
    {
        /// <summary>
        /// Get all nationalities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NationalityDto>> GetAllNationalitiesAsync();

        /// <summary>
        /// Create new Nationality
        /// </summary>
        /// <param name="request"></param>
        /// <param name="fullName"></param>
        /// <returns></returns>
        Task<NationalityDto> AddNationalityAsync(AddNationalityRequestDto request, string fullName);
        Task DeleteNationalityAsync(int id);
    }
}
