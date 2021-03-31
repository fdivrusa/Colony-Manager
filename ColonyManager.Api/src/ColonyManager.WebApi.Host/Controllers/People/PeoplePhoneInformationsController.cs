using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.People
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeoplePhoneInformationsController : BaseController
    {
        private readonly IPeoplePhoneInformationService _peoplePhoneInformationService;

        public PeoplePhoneInformationsController(IPeoplePhoneInformationService peoplePhoneInformationService)
        {
            _peoplePhoneInformationService = peoplePhoneInformationService;
        }

        [HttpGet]
        [Route("peopleId/{peopleId}")]
        public async Task<IEnumerable<PeoplePhoneInformationDto>> GetPeoplePhoneInformationsAsync(int peopleId)
        {
            return await _peoplePhoneInformationService.GetPeoplePhoneInformationsAsync(peopleId);
        }
    }
}
