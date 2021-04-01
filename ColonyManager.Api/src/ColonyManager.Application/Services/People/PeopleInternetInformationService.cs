using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class PeopleInternetInformationService : IPeopleInternetInformationService
    {

        private readonly IMapper _mapper;
        private readonly ILogger<PeopleInternetInformationService> _logger;
        private readonly ColonyManagerDbContext _dbContext;

        public PeopleInternetInformationService(IMapper mapper, ILogger<PeopleInternetInformationService> logger, ColonyManagerDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PeopleInternetInformationDto>> GetPeopleInternetInformationsAsync(int peopleId)
        {
            _logger.LogDebug($"Getting internet informations for people with ID {peopleId}");
            return _mapper.Map<IEnumerable<PeopleInternetInformationDto>>(await _dbContext.PeopleInternetInformations.Where(x => x.PeopleId == peopleId).ToListAsync());
        }
    }
}
