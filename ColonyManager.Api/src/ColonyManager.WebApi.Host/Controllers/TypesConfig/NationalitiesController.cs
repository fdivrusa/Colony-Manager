using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.TypesConfig
{
    [ApiController]
    [Route("api/[controller]")]
    public class NationalitiesController : BaseController
    {
        private readonly INationalityService _service;

        public NationalitiesController(INationalityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<NationalityDto>> GetNationalitiesAsync()
        {
            return await _service.GetAllNationalitiesAsync();
        }
    }
}
