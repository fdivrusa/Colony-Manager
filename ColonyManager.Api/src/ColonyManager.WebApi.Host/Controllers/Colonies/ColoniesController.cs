using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColoniesController : BaseController
    {
        private readonly IColonyService _colonyService;

        public ColoniesController(IColonyService colonyService)
        {
            _colonyService = colonyService;
        }

        [HttpGet]
        public async Task<IEnumerable<ColonyDto>> GetColoniesAsync()
        {
            return await _colonyService.GetAllColoniesAsync();
        }
    }
}
