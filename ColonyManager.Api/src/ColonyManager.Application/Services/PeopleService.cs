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
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class PeopleService : IPeopleService
    {

        private readonly ILogger<PeopleService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddPeopleRequestDto> _addValidator;
        private readonly IValidator<UpdatePeopleRequestDto> _updateValidator;

        public PeopleService(ILogger<PeopleService> logger, IMapper mapper, ColonyManagerDbContext dbContext,
            IValidator<AddPeopleRequestDto> addValidator,
            IValidator<UpdatePeopleRequestDto> updateValidator)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<PeopleDto>> GetAllPeoplesAsync()
        {
            _logger.LogDebug("Get all people call");
            return _mapper.Map<List<PeopleDto>>(await _dbContext.Peoples.ToListAsync());
        }

        public async Task<PeopleDto> AddPeopleAsync(AddPeopleRequestDto request, string userName)
        {
            _logger.LogDebug($"Add new people. Request : {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<People>(request);
            entity.Deceased = false;
            entity.IsActive = true;
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.Peoples.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<PeopleDto>(entity);
        }

        public async Task<PeopleDto> UpdatePeopleAsync(UpdatePeopleRequestDto request, string userName)
        {
            _logger.LogError($"Update existing people. Request : {JsonConvert.SerializeObject(request)}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.Peoples.SingleOrDefaultAsync(x => x.Id == request.Id);
            if (entity != null)
            {
                _mapper.Map(request, entity);
                entity.LastUpdatedDate = DateTime.Now;
                entity.LastUpdatedUserName = userName;

                _dbContext.Update(entity);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<PeopleDto>(entity);
            }

            _logger.LogError($"Cannot find people entity with Id {request.Id}");
            return null;
        }
    }
}
