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
    public class PeopleInternetInformationService : IPeopleInternetInformationService
    {

        private readonly IMapper _mapper;
        private readonly ILogger<PeopleInternetInformationService> _logger;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddPeopleInternetInformationRequestDto> _addValidator;
        private readonly IValidator<UpdatePeopleInternetInformationRequestDto> _updateValidator;

        public PeopleInternetInformationService(IMapper mapper, ILogger<PeopleInternetInformationService> logger, ColonyManagerDbContext dbContext,
            IValidator<AddPeopleInternetInformationRequestDto> addValidator,
            IValidator<UpdatePeopleInternetInformationRequestDto> updateValidator)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<PeopleInternetInformationDto>> GetPeopleInternetInformationsAsync(int peopleId)
        {
            _logger.LogDebug($"Getting internet informations for people with ID {peopleId}");
            return _mapper.Map<IEnumerable<PeopleInternetInformationDto>>(await _dbContext.PeopleInternetInformations.Where(x => x.PeopleId == peopleId).ToListAsync());
        }

        public async Task<PeopleInternetInformationDto> AddPeopleInternetInformationAsync(AddPeopleInternetInformationRequestDto request, string userName)
        {
            _logger.LogDebug($"Adding new internet information for people with ID {request.PeopleId}. Request {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<PeopleInternetInformation>(request);
            entity.IsObsolete = false;
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.PeopleInternetInformations.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<PeopleInternetInformationDto>(entity);
        }

        public async Task<PeopleInternetInformationDto> UpdatePeopleInternetInformationAsync(UpdatePeopleInternetInformationRequestDto request, string userName)
        {
            _logger.LogDebug($"Update internet information with ID {request.Id}. Request {JsonConvert.SerializeObject(request)}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.PeopleInternetInformations.SingleOrDefaultAsync(x => x.Id == request.Id);
            if (entity == null)
            {
                _logger.LogError($"Cannot find people internet information with ID {request.Id}");
                return null;
            }

            _mapper.Map(request, entity);
            entity.LastUpdatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<PeopleInternetInformationDto>(entity);
        }
    }
}
