using AutoMapper;
using ColonyManager.Application.Helpers;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class ConfigGenericItemExtentionService : IConfigGenericItemExtentionService
    {

        private readonly ColonyManagerDbContext _dbContext;
        private readonly ILogger<ConfigGenericItemExtentionService> _logger;
        private readonly IMapper _mapper;
        private readonly IValidator<AddConfigGenericItemExtentionRequestDto> _addValidator;
        private readonly IValidator<UpdateConfigGenericItemExtentionRequestDto> _updateValidator;

        public ConfigGenericItemExtentionService(ColonyManagerDbContext dbContext, ILogger<ConfigGenericItemExtentionService> logger, IMapper mapper,
            IValidator<AddConfigGenericItemExtentionRequestDto> addValidator,
            IValidator<UpdateConfigGenericItemExtentionRequestDto> updateValidator)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<ConfigGenericItemExtentionDto> AddConfigGenericItemExtentionAsync(AddConfigGenericItemExtentionRequestDto request, string userName)
        {
            _logger.LogDebug($"Adding new Config generic item extention. Request : {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<ConfigGenericItemExtension>(request);
            entity.Id = await GetNextIdHelper.GetNextIdConfigItemExtentionAsync(request, _dbContext);
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.ConfigGenericItemExtensions.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ConfigGenericItemExtentionDto>(entity);
        }

        public async Task DeleteConfigGenericItemExtentionAsync(ConfigGenericItemExtentionDto request)
        {
            _logger.LogDebug($"Deleting config generic item extention with request : {JsonConvert.SerializeObject(request)}");

            var entity = await _dbContext.ConfigGenericItemExtensions.SingleOrDefaultAsync(x => x.GroupId == request.GroupId && x.Id == request.Id && x.Id == request.Id);
            if (entity != null)
            {
                _dbContext.ConfigGenericItemExtensions.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                _logger.LogError($"Cannot find config generic item extention to delete with group Id {request.GroupId}, Item id {request.ItemId} and Id {request.Id}");
            }
        }

        public async Task<ConfigGenericItemExtentionDto> UpdateConfigGenericItemExtentionAsync(UpdateConfigGenericItemExtentionRequestDto request, string userName)
        {
            _logger.LogDebug($"Update config generic item extention with request : {JsonConvert.SerializeObject(request)}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.ConfigGenericItemExtensions.SingleOrDefaultAsync(x => x.GroupId == request.GroupId && x.ItemId == request.ItemId && x.Id == request.Id);
            if (entity != null)
            {
                _mapper.Map(request, entity);
                entity.LastUpdatedDate = DateTime.Now;
                entity.LastUpdatedUserName = userName;

                _dbContext.ConfigGenericItemExtensions.Update(entity);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<ConfigGenericItemExtentionDto>(entity);
            }

            _logger.LogError($"Cannot find config generic item extention to update with request {JsonConvert.SerializeObject(request)}");
            return null;
        }
    }
}
