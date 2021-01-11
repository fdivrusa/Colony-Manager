using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Services
{
    public interface IBaseService<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T dto, int userId);
        Task<T> UpdateAsync(T dto, int userId);
    }
}
