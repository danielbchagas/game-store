using GameStore.Catalog.Api.Domain.Interfaces.Repositories;
using GameStore.Catalog.Api.Infrastructure.Repositories;

namespace GameStore.Catalog.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
