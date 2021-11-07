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
    public class NationalityService : INationalityService
    {
        private readonly ILogger<NationalityService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;

        public NationalityService(ILogger<NationalityService> logger, IMapper mapper, ColonyManagerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<NationalityDto>> GetAllNationalitiesAsync()
        {
            _logger.LogDebug("Get all nationalities");
            return _mapper.Map<IEnumerable<NationalityDto>>(await _dbContext.Nationalities.ToListAsync());
        }
    }
}
