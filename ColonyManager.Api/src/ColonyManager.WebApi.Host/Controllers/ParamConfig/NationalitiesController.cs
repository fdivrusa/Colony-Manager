using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.ParamConfig
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
        public async Task<IEnumerable<NationalityDto>> Get()
        {
            return await _service.GetAllNationalitiesAsync();
        }

        [HttpPost]
        public async Task<NationalityDto> Create(AddNationalityRequestDto request)
        {
            return await _service.AddNationalityAsync(request, Account?.FullName);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteNationalityAsync(id);
            return Ok();
        }
    }
}
