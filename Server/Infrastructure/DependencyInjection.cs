﻿using Infrastructure.DbContext;
using Infrastructure.Repo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton(new Context(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IRepository, Repository>();

        return services;
    }
}
