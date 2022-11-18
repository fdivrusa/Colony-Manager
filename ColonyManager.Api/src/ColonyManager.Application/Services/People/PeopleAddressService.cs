using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class PeopleAddressService : IPeopleAddressService
    {
        private readonly ILogger<PeopleAddressService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;

        public PeopleAddressService(ILogger<PeopleAddressService> logger, IMapper mapper, ColonyManagerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PeopleAddressDto>> GetPeopleAddressesAsync(int peopleId)
        {
            _logger.LogDebug($"Get all people addresses for people with Id {peopleId}");
            return _mapper.Map<IEnumerable<PeopleAddressDto>>(await _dbContext.PeopleAddresses.Where(x => x.PeopleId == peopleId).ToListAsync());
        }
    }
}
