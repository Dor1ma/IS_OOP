using Lab5Project.Presentation.Console.Scenarios.Admin.Login;
using Lab5Project.Presentation.Console.Scenarios.User.CreateAccount;
using Lab5Project.Presentation.Console.Scenarios.User.Login;
using Lab5Project.Presentation.Console.Scenarios.User.Replenishment;
using Lab5Project.Presentation.Console.Scenarios.User.ShowBalance;
using Lab5Project.Presentation.Console.Scenarios.User.Withdrawal;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5Project.Presentation.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();
        collection.AddScoped<WelcomeScenarioRunner>();

        collection.AddScoped<IWelcomeScenarioProvider, LoginScenarioProvider>();
        collection.AddScoped<IWelcomeScenarioProvider, AdminLoginScenarioProvider>();
        collection.AddScoped<IWelcomeScenarioProvider, CreateAccountScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ReplenishmentScenarioProvider>();
        collection.AddScoped<IScenarioProvider, WithdrawalScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ShowBalanceScenarioProvider>();

        return collection;
    }
}