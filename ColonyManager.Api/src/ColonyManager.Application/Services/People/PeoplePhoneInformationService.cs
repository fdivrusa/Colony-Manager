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
    public class PeoplePhoneInformationService : IPeoplePhoneInformationService
    {

        private readonly ILogger<PeoplePhoneInformationService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddPeoplePhoneRequestDto> _addValidator;
        private readonly IValidator<UpdatePeoplePhoneRequestDto> _updateValidator;

        public PeoplePhoneInformationService(ILogger<PeoplePhoneInformationService> logger, IMapper mapper, ColonyManagerDbContext dbContext,
            IValidator<AddPeoplePhoneRequestDto> addValidator,
            IValidator<UpdatePeoplePhoneRequestDto> updateValidator)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<PeoplePhoneInformationDto>> GetPeoplePhoneInformationsAsync(int peopleId)
        {
            _logger.LogDebug($"Getting phone informations for people with people id {peopleId}");
            return _mapper.Map<IEnumerable<PeoplePhoneInformationDto>>(await _dbContext.PeoplePhoneInformations.Where(x => x.PeopleId == peopleId).ToListAsync());
        }

        public async Task<PeoplePhoneInformationDto> AddPeoplePhoneInformationAsync(AddPeoplePhoneRequestDto request, string userName)
        {
            _logger.LogDebug($"Adding new phone information for people with ID {request.PeopleId}. Request : {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<PeoplePhoneInformation>(request);
            entity.IsObsolete = false;
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.PeoplePhoneInformations.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<PeoplePhoneInformationDto>(entity);
        }

        public async Task<PeoplePhoneInformationDto> UpdatePeoplePhoneInformationAsync(UpdatePeoplePhoneRequestDto request, string userName)
        {
            _logger.LogDebug($"Updating existing phone information with ID {request.Id}. Request : {JsonConvert.SerializeObject(request)}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.PeoplePhoneInformations.SingleOrDefaultAsync(x => x.Id == request.Id);
            if (entity == null)
            {
                _logger.LogError($"Cannot find people phone information with ID {request.Id}");
                return null;
            }

            _mapper.Map(request, entity);
            entity.LastUpdatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<PeoplePhoneInformationDto>(entity);
        }
    }
}
