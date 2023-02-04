using GameStore.Customer.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Customer.Api.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static IServiceCollection ConfigureEntityFramework(this IServiceCollection services, IConfiguration configuration)
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
