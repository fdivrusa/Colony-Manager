using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class NationalityService : INationalityService
    {
        private readonly ILogger<NationalityService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddNationalityRequestDto> _addValidator;

        public NationalityService(ILogger<NationalityService> logger, IMapper mapper, ColonyManagerDbContext dbContext,
            IValidator<AddNationalityRequestDto> addValidator)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
            _addValidator = addValidator;
        }

        public async Task<IEnumerable<NationalityDto>> GetAllNationalitiesAsync()
        {
            _logger.LogDebug("Get all nationalities");
            return _mapper.Map<IEnumerable<NationalityDto>>(await _dbContext.Nationalities.ToListAsync());
        }

        public async Task<NationalityDto> AddNationalityAsync(AddNationalityRequestDto request, string userName)
        {
            _logger.LogDebug($"Create new Nationality. Request : {JsonConvert.SerializeObject(request)}");

            if ((await _dbContext.Nationalities.ToListAsync()).Any(x => x.Code.Equals(request.Code, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Entity already exists in the database with the same code");
            }

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<Nationality>(request);
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.Nationalities.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<NationalityDto>(entity);
        }

        public async Task DeleteNationalityAsync(int id)
        {
            _logger.LogDebug($"Delete nationality with id {id}");

            var entity = await _dbContext.Nationalities.SingleOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                _dbContext.Nationalities.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
