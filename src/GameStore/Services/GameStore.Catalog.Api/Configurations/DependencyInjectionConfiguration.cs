using GameStore.Catalog.Interfaces.Repositories;
using GameStore.Catalog.Repositories;

namespace GameStore.Catalog.Configurations
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
