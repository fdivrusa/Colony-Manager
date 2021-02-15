using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyManager.Application.Helpers
{
    public class GetNextIdHelper
    {
        protected GetNextIdHelper()
        {

        }

        public static async Task<int> GetNextIdConfigItemAsync(AddConfigGenericItemRequestDto request, ColonyManagerDbContext dbContext)
        {
            return await dbContext.Set<ConfigGenericItem>()
                                               .Where(x => x.GroupId == request.GroupId)
                                               .DefaultIfEmpty()
                                               .MaxAsync(x => (int?)x.Id) + 1 ?? 1;
        }
    }
}
