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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class ConfigGenericItemService : IConfigGenericItemService
    {
        private readonly ILogger<ConfigGenericItemService> _logger;
        private readonly IMapper _mapper;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddConfigGenericItemRequestDto> _addConfigGenericItemValidator;
        private readonly IValidator<UpdateConfigGenericItemRequestDto> _updateValidator;

        public ConfigGenericItemService(ILogger<ConfigGenericItemService> logger, IMapper mapper, ColonyManagerDbContext colonyManagerDbContext,
            IValidator<AddConfigGenericItemRequestDto> addConfigGenericItemValidator, IValidator<UpdateConfigGenericItemRequestDto> updateValidator)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = colonyManagerDbContext;
            _addConfigGenericItemValidator = addConfigGenericItemValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<ConfigGenericItemDto>> GetConfigGenericItemByGroupCodeAsync(string code)
        {
            _logger.LogDebug($"Get generic items by group code {code}");
            return _mapper.Map<IEnumerable<ConfigGenericItemDto>>(await _dbContext.ConfigGenericItems
                .Include(x => x.ConfigGenericGroup)
                .Where(x => x.ConfigGenericGroup.Code.ToUpper() == code.ToUpper())
                .ToListAsync());
        }

        public async Task<IEnumerable<ConfigGenericItemDto>> GetConfigGenericItemByGroupIdAsync(int id)
        {
            _logger.LogDebug($"Get generic items by group id {id}");
            return _mapper.Map<IEnumerable<ConfigGenericItemDto>>(await _dbContext.ConfigGenericItems
                .Where(x => x.GroupId == id)
                .ToListAsync());
        }

        public async Task<ConfigGenericItemDto> GetConfigGenericItemByCodesAsync(string groupCode, string itemCode)
        {
            _logger.LogDebug($"Get generic item by group code {groupCode} and item code {itemCode}");
            return _mapper.Map<ConfigGenericItemDto>(await _dbContext.ConfigGenericItems
                .Include(x => x.ConfigGenericGroup)
                .SingleOrDefaultAsync(x => x.ConfigGenericGroup.Code.ToUpper() == groupCode.ToUpper() && x.Code.ToUpper() == itemCode.ToUpper()));
        }

        public async Task<ConfigGenericItemDto> AddNewConfigGenericItemAsync(AddConfigGenericItemRequestDto request, string userName)
        {

            _logger.LogDebug($"Adding new config generic item : {JsonConvert.SerializeObject(request)}");
            await _addConfigGenericItemValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<ConfigGenericItem>(request);
            entity.Id = await GetNextIdHelper.GetNextIdConfigItemAsync(request, _dbContext);
            entity.LastUpdatedUserName = userName;

            _dbContext.ConfigGenericItems.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ConfigGenericItemDto>(entity);
        }

        public async Task DeleteConfigGenericItemAsync(DeleteConfigGenericItemDto request)
        {
            _logger.LogDebug($"Deleting config generic item with group Id {request.GroupId} and Id {request.Id}");

            var entity = await _dbContext.ConfigGenericItems.SingleOrDefaultAsync(x => x.GroupId == request.GroupId && x.Id == request.Id);
            if (entity != null)
            {
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                _logger.LogError($"Cannot delete config generic item with group Id {request.GroupId} and Id {request.Id}");
            }
        }

        public async Task<ConfigGenericItemDto> UpdateConfigGenericItemDto(UpdateConfigGenericItemRequestDto request, string userName)
        {
            _logger.LogDebug($"Updating config generic item with group Id {request.GroupId} and Id {request.Id}");

            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.ConfigGenericItems.SingleOrDefaultAsync(x => x.GroupId == request.GroupId && x.Id == request.Id);
            if (entity != null)
            {
                _mapper.Map(request, entity);
                entity.LastUpdatedDate = DateTime.Now;
                entity.LastUpdatedUserName = userName;

                _dbContext.Update(entity);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<ConfigGenericItemDto>(entity);
            }

            _logger.LogError($"Update config generic item, entity not found : Cannot found entity with groupId {request.GroupId} and Id {request.Id}");
            return null;
        }
    }
}
