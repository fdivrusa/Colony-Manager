using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeoplesController : BaseController
    {
        private readonly IPeopleService _peopleService;

        public PeoplesController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public async Task<IEnumerable<PeopleDetailedDto>> GetAllPeoplesAsync()
        {
            return await _peopleService.GetAllPeoplesAsync();
        }

        [HttpPost]
        public async Task<PeopleDetailedDto> AddPeopleAsync([FromBody] AddPeopleRequestDto request)
        {
            return await _peopleService.AddPeopleAsync(request, Account?.FullName);
        }

        [HttpPut]
        public async Task<PeopleDetailedDto> UpdatePeopleAsync([FromBody] UpdatePeopleRequestDto request)
        {
            return await _peopleService.UpdatePeopleAsync(request, Account?.FullName);
        }
    }
}
