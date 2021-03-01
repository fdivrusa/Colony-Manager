using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IEnumerable<PeopleDto>> GetAllPeoplesAsync()
        {
            return await _peopleService.GetAllPeoplesAsync();
        }
    }
}
