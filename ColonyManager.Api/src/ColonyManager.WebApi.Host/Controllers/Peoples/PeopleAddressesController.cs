using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Peoples
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleAddressesController : BaseController
    {
        private readonly IPeopleAddressService _peopleAddressService;

        public PeopleAddressesController(IPeopleAddressService peopleAddressService)
        {
            _peopleAddressService = peopleAddressService;
        }

        [HttpGet("{peopleId}")]
        public async Task<IEnumerable<PeopleAddressDto>> GetPeoplesAddressesAsync(int peopleId)
        {
            return await _peopleAddressService.GetPeopleAddressesAsync(peopleId);
        }
    }
}
