using ColonyManager.Data;
using ColonyManager.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Application
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TDto> 
        where TEntity : class 
        where TDto : class
    {
        protected readonly IDbContextFactory<ColonyManagerDbContext> _colonyManagerDbContext;

        public BaseService(IDbContextFactory<ColonyManagerDbContext> colonyManagerDbContext)
        {
            _colonyManagerDbContext = colonyManagerDbContext;
        }

        public Task<TDto> AddAsync(TDto dto, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> UpdateAsync(TDto dto, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
