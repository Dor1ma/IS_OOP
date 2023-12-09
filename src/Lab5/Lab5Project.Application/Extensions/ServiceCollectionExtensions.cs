using Lab5Project.Application.Contracts.Users;
using Lab5Project.Application.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5Project.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<CurrentUserManager>();
        collection.AddScoped<ICurrentUserService>(
            p => p.GetRequiredService<CurrentUserManager>());

        return collection;
    }
}