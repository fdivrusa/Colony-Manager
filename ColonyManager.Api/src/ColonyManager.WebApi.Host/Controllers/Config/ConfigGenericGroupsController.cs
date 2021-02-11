using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.Config
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigGenericGroupsController : BaseController
    {
        private readonly IConfigGenericGroupService _configGenericGroupService;

        public ConfigGenericGroupsController(IConfigGenericGroupService configGenericGroupService)
        {
            _configGenericGroupService = configGenericGroupService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroupsAsync()
        {
            return await _configGenericGroupService.GetAllGenericGroupsAsync();
        }

        [HttpGet]
        [Route("relatedSubject/{relatedSubject}")]
        public async Task<IEnumerable<ConfigGenericGroupDto>> GetGenericGroupsByRelatedSubjectAsync(string relatedSubject)
        {
            return await _configGenericGroupService.GetGenericGroupsByRelatedSubjectAsync(relatedSubject);
        }

        [HttpGet]
        [Route("code/{code}/details")]
        public async Task<ConfigGenericGroupDetailedDto> GetGenericGroupByCodeAsync(string code)
        {
            return await _configGenericGroupService.GetGenericGroupByCodeAsync(code);
        }

        [HttpGet]
        [Route("details")]
        public async Task<ConfigGenericGroupDetailedDto> GetGenericGroupByIdAsync(int id)
        {
            return await _configGenericGroupService.GetGenericGroupByIdAsync(id);
        }

        [HttpPost]
        public async Task<ConfigGenericGroupDto> AddConfigGenericGroupAsync(AddConfigGenericGroupDto request)
        {
            return await _configGenericGroupService.AddNewConfigGenericGroupAsync(request, Account?.LastName);
        }
    }
}
