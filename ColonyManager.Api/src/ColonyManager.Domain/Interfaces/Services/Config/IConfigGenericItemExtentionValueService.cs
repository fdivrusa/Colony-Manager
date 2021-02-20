using ColonyManager.Domain.Models;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IConfigGenericItemExtentionValueService
    {
        Task<ConfigGenericItemExtentionValueDto> AddConfigGenericItemExtentionValueAsync(AddConfigGenericItemExtentionValueRequestDto request, string userName);
    }
}
