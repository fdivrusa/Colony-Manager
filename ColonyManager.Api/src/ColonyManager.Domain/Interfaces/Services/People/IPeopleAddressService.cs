using ColonyManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IPeopleAddressService
    {
        Task<IEnumerable<PeopleAddressDto>> GetPeopleAddressesAsync(int peopleId);
    }
}
