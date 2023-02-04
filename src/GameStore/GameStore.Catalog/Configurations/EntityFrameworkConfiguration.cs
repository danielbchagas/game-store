using GameStore.Catalog.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Catalog.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static IServiceCollection Configure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            return services;
        }
    }
}
