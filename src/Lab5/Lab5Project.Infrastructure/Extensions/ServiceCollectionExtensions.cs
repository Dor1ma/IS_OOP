using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Models;
using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5Project.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureDataAccess(
        this IServiceCollection collection,
        Action<PostgresConnectionConfiguration> configuration)
    {
        collection.AddPlatformPostgres(builder => builder.Configure(configuration));
        collection.AddPlatformMigrations(typeof(ServiceCollectionExtensions).Assembly);
        collection.AddScoped<IUsersRepository, UsersRepository>();

        return collection;
    }
}