using AutoMapper;
using ColonyManager.Application.Helpers;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class ConfigGenericItemExtentionValueService : IConfigGenericItemExtentionValueService
    {

        private readonly ColonyManagerDbContext _dbContext;
        private readonly ILogger<ConfigGenericItemExtentionValueService> _logger;
        private readonly IMapper _mapper;
        private readonly IValidator<AddConfigGenericItemExtentionValueRequestDto> _addValidator;

        public ConfigGenericItemExtentionValueService(ColonyManagerDbContext dbContext, ILogger<ConfigGenericItemExtentionValueService> logger, IMapper mapper,
            IValidator<AddConfigGenericItemExtentionValueRequestDto> addValidator)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
            _addValidator = addValidator;
        }

        public async Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync(AddConfigGenericItemExtentionValueRequestDto request, string userName)
        {
            _logger.LogDebug($"Add new config generic item extention value. Request : {JsonConvert.SerializeObject(request)}");

            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<ConfigGenericItemExtensionValue>(request);
            entity.Id = await GetNextIdHelper.GetNextIdConfigItemExtentionValueAsync(request, _dbContext);
            entity.LastUpdatedUserName = userName;

            _dbContext.ConfigGenericItemExtensionValues.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ConfigGenericItemExtentionValueDto>(entity);
        }
    }
}
