using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ColonyManager.Data
{
    public static class ColonyManagerDbContextConfiguration
    {
        public static IServiceCollection ConfigureColonyManagerDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ColonyManagerDbContext>(options =>
            {
                options.UseSqlServer(connectionString,
                    x => x.UseNetTopologySuite());
            });
            return services;
        }
    }
}
