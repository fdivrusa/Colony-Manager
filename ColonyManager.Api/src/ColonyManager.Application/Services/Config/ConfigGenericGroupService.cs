using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class ConfigGenericGroupService : IConfigGenericGroupService
    {

        private readonly IMapper _mapper;
        private readonly ILogger<ConfigGenericGroupService> _logger;
        private readonly ColonyManagerDbContext _dbContext;

        public ConfigGenericGroupService(IMapper mapper, ILogger<ConfigGenericGroupService> logger, ColonyManagerDbContext dbContext)
        {
            _mapper = mapper;
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroups()
        {
            _logger.LogDebug("Getting all config generic groups");
            return _mapper.Map<IEnumerable<ConfigGenericGroupDto>>(await _dbContext.ConfigGenericGroups.ToListAsync());
        }
    }
}
