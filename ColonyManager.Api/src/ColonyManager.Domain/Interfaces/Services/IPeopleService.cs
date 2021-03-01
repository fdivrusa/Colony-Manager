using ColonyManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    /// <summary>
    /// Return all the people
    /// </summary>
    public interface IPeopleService
    {
        Task<IEnumerable<PeopleDto>> GetAllPeoplesAsync();
    }
}
