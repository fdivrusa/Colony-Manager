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
    public class ConfigGenericItemExtentionValueService : IConfigGenericItemExtentionValueService
    {

        private readonly ColonyManagerDbContext _dbContext;
        private readonly ILogger<ConfigGenericItemExtentionValueService> _logger;
        private readonly IMapper _mapper;
        private readonly IValidator<AddConfigGenericItemExtentionValueRequestDto> _addValidator;
        private readonly IValidator<UpdateConfigGenericItemExtentionValueRequestDto> _updateValidator;

        public ConfigGenericItemExtentionValueService(ColonyManagerDbContext dbContext, ILogger<ConfigGenericItemExtentionValueService> logger, IMapper mapper,
            IValidator<AddConfigGenericItemExtentionValueRequestDto> addValidator,
            IValidator<UpdateConfigGenericItemExtentionValueRequestDto> updateValidator)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync(AddConfigGenericItemExtentionValueRequestDto request, string userName)
        {
            _logger.LogDebug($"Add new config generic item extention value. Request : {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<ConfigGenericItemExtensionValue>(request);
            entity.Id = await GetNextIdHelper.GetNextIdConfigItemExtentionValueAsync(request, _dbContext);
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.ConfigGenericItemExtensionValues.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ConfigGenericItemExtentionValueDto>(entity);
        }

        public async Task<ConfigGenericItemExtentionValueDto> UpdateConfigGenericItemExtentionValueAsync(UpdateConfigGenericItemExtentionValueRequestDto request, string userName)
        {
            _logger.LogDebug($"Update existing config generic item extention value. Request : {JsonConvert.SerializeObject(request)}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.ConfigGenericItemExtensionValues.SingleOrDefaultAsync(x => x.GroupId == request.GroupId &&
                                                                                                x.ItemId == request.ItemId &&
                                                                                                x.ExtentionId == request.ExentionId &&
                                                                                                x.Id == request.Id);
            if (entity != null)
            {
                _mapper.Map(request, entity);

                entity.LastUpdatedDate = DateTime.Now;
                entity.LastUpdatedUserName = userName;

                _dbContext.Update(entity);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<ConfigGenericItemExtentionValueDto>(entity);
            }

            _logger.LogError($"Cannot update generic config item extention value. Request : {JsonConvert.SerializeObject(request)}");
            return null;
        }


        public async Task DeleteConfigGenericItemExtentionValueAsync(ConfigGenericItemExtentionValueDto request)
        {
            _logger.LogDebug($"Delete config generic item extention value {JsonConvert.SerializeObject(request)}");

            var entity = await _dbContext.ConfigGenericItemExtensionValues.SingleOrDefaultAsync(x => x.GroupId == request.GroupId &&
                                                                                               x.ItemId == request.ItemId &&
                                                                                               x.ExtentionId == request.ExtentionId &&
                                                                                               x.Id == request.Id);
            if (entity != null)
            {
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                _logger.LogDebug($"Cannot delete config generic item extention value {JsonConvert.SerializeObject(request)}");
            }
        }
    }
}
