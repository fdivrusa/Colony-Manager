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
    public class GenderService : IGenderService
    {
        private readonly ILogger<GenderService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;

        public GenderService(ILogger<GenderService> logger, IMapper mapper, ColonyManagerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GenderDto>> GetAllGendersAsync()
        {
            _logger.LogDebug("Get all genders");
            return _mapper.Map<IEnumerable<GenderDto>>(await _dbContext.Genders.ToListAsync());
        }
    }
}
