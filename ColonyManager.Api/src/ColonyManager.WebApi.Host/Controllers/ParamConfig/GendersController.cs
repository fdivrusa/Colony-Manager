using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.ParamConfig
{
    [ApiController]
    [Route("api/[controller]")]
    public class GendersController : BaseController
    {
        private readonly IGenderService _service;

        public GendersController(IGenderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<GenderDto>> GetGendersAsync()
        {
            return await _service.GetAllGendersAsync();
        }
    }
}
