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
    public class PeoplePhoneInformationService : IPeoplePhoneInformationService
    {

        private readonly ILogger<PeoplePhoneInformationService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;

        public PeoplePhoneInformationService(ILogger<PeoplePhoneInformationService> logger, IMapper mapper, ColonyManagerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PeoplePhoneInformationDto>> GetPeoplePhoneInformationsAsync(int peopleId)
        {
            _logger.LogDebug($"Getting phone informations for people with people id {peopleId}");
            return _mapper.Map<IEnumerable<PeoplePhoneInformationDto>>(await _dbContext.PeoplePhoneInformations.Where(x => x.PeopleId == peopleId).ToListAsync());
        }
    }
}
