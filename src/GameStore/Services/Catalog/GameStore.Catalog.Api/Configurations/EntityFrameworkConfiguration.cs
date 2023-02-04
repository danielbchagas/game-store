﻿using GameStore.Catalog.Api.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Catalog.Api.Configurations
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
