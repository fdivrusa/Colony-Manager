using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class PeopleService : IPeopleService
    {

        private readonly ILogger<PeopleService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;

        public PeopleService(ILogger<PeopleService> logger, IMapper mapper, ColonyManagerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PeopleDto>> GetAllPeoplesAsync()
        {
            _logger.LogDebug("Get all people call");
            return _mapper.Map<List<PeopleDto>>(await _dbContext.Peoples.ToListAsync());
        }
    }
}
