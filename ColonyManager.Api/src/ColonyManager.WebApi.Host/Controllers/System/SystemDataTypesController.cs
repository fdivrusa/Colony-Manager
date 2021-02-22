using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemDataTypesController : BaseController
    {
        private readonly ISystemDataTypeService _systemDataTypeService;

        public SystemDataTypesController(ISystemDataTypeService systemDataTypeService)
        {
            _systemDataTypeService = systemDataTypeService;
        }

        [HttpGet]
        public async Task<IEnumerable<SystemDataTypeDto>> GetAllSystemDataTypesAsync()
        {
            return await _systemDataTypeService.GetAllSystemDataTypesAsync();
        }

        [HttpPost]
        public async Task<SystemDataTypeDto> AddSystemDataTypeAsync(AddSystemDataTypeRequestDto request)
        {
            return await _systemDataTypeService.AddSystemDataTypeAsync(request, Account?.FullName);
        }

        [HttpPut]
        public async Task<SystemDataTypeDto> UpdateSystemDataTypeDto(UpdateSystemDataTypeRequestDto request)
        {
            return await _systemDataTypeService.UpdateSystemDataTypeAsync(request, Account?.FullName);
        }
    }
}
