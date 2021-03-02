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
    public class SystemDataTypeService : ISystemDataTypeService
    {
        private readonly ColonyManagerDbContext _dbContext;
        private readonly ILogger<SystemDataTypeService> _logger;
        private readonly IMapper _mapper;
        private readonly IValidator<AddSystemDataTypeRequestDto> _addValidator;
        private readonly IValidator<UpdateSystemDataTypeRequestDto> _updateValidator;

        public SystemDataTypeService(ColonyManagerDbContext dbContext, ILogger<SystemDataTypeService> logger, IMapper mapper,
            IValidator<AddSystemDataTypeRequestDto> addValidator,
            IValidator<UpdateSystemDataTypeRequestDto> updateValidator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
            _addValidator = addValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IEnumerable<SystemDataTypeDto>> GetAllSystemDataTypesAsync()
        {
            _logger.LogDebug("Getting all system data types");
            return _mapper.Map<IEnumerable<SystemDataTypeDto>>(await _dbContext.SystemDataTypes.ToListAsync());
        }

        public async Task<SystemDataTypeDto> AddSystemDataTypeAsync(AddSystemDataTypeRequestDto request, string userName)
        {
            _logger.LogDebug($"Add new system data type. Request : {JsonConvert.SerializeObject(request)}");
            await _addValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<SystemDataType>(request);
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedUserName = userName;

            _dbContext.SystemDataTypes.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<SystemDataTypeDto>(entity);
        }

        public async Task<SystemDataTypeDto> UpdateSystemDataTypeAsync(UpdateSystemDataTypeRequestDto request, string userName)
        {
            _logger.LogDebug($"Update system data type. Request : {JsonConvert.SerializeObject(request)}");
            await _updateValidator.ValidateAndThrowAsync(request);

            var entity = await _dbContext.SystemDataTypes.SingleOrDefaultAsync(x => x.Id == request.Id);
            if (entity != null)
            {
                _mapper.Map(request, entity);
                entity.LastUpdatedDate = DateTime.Now;
                entity.LastUpdatedUserName = userName;

                _dbContext.SystemDataTypes.Update(entity);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<SystemDataTypeDto>(entity);
            }

            _logger.LogError($"Cannot find system data type. Request : {JsonConvert.SerializeObject(request)}");
            return null;
        }


    }
}
