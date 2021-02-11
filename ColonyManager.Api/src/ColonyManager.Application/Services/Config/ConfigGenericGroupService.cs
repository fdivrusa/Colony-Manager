using AutoMapper;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyManager.Application.Services
{
    public class ConfigGenericGroupService : IConfigGenericGroupService
    {

        private readonly IMapper _mapper;
        private readonly ILogger<ConfigGenericGroupService> _logger;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IValidator<AddConfigGenericGroupDto> _addConfigGenericGroupValidator;

        public ConfigGenericGroupService(IMapper mapper, ILogger<ConfigGenericGroupService> logger, ColonyManagerDbContext dbContext, IValidator<AddConfigGenericGroupDto> addConfigGenericGroupValidator)
        {
            _mapper = mapper;
            _logger = logger;
            _dbContext = dbContext;
            _addConfigGenericGroupValidator = addConfigGenericGroupValidator;
        }

        public async Task<IEnumerable<ConfigGenericGroupDto>> GetAllGenericGroupsAsync()
        {
            _logger.LogDebug("Getting all config generic groups");
            return _mapper.Map<IEnumerable<ConfigGenericGroupDto>>(await _dbContext.ConfigGenericGroups.ToListAsync());
        }

        public async Task<IEnumerable<ConfigGenericGroupDto>> GetGenericGroupsByRelatedSubjectAsync(string relatedSubject)
        {
            _logger.LogDebug($"Getting groups by related subject : {relatedSubject}");
            return _mapper.Map<IEnumerable<ConfigGenericGroupDto>>(await _dbContext.ConfigGenericGroups.Where(x => x.RelatedSubject.ToUpper() == relatedSubject.ToUpper()).ToListAsync());
        }

        public async Task<ConfigGenericGroupDetailedDto> GetGenericGroupByCodeAsync(string code)
        {
            _logger.LogDebug($"Getting group by code : {code}");
            return _mapper.Map<ConfigGenericGroupDetailedDto>(await _dbContext.ConfigGenericGroups
                .Include(x => x.ConfigGenericItems)
                .SingleOrDefaultAsync(x => x.Code.ToUpper() == code.ToUpper()));
        }

        public async Task<ConfigGenericGroupDetailedDto> GetGenericGroupByIdAsync(int Id)
        {
            _logger.LogDebug($"Getting group by Id : {Id}");
            return _mapper.Map<ConfigGenericGroupDetailedDto>(await _dbContext.ConfigGenericGroups
                .Include(x => x.ConfigGenericItems)
                .SingleOrDefaultAsync(x => x.Id == Id));
        }

        public async Task<ConfigGenericGroupDto> AddNewConfigGenericGroupAsync(AddConfigGenericGroupDto request, string userName)
        {
            await _addConfigGenericGroupValidator.ValidateAndThrowAsync(request);

            var entity = _mapper.Map<ConfigGenericGroup>(request);
            entity.LastUpdatedUserName = userName;

            var result = _dbContext.ConfigGenericGroups.Add(entity).Entity;
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ConfigGenericGroupDto>(result);
        }
    }
}
