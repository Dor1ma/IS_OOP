using Lab5Project.Application.Extensions;
using Lab5Project.Infrastructure.Extensions;
using Lab5Project.Presentation.Console;
using Lab5Project.Presentation.Console.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;

var collection = new ServiceCollection();

collection
    .AddApplication()
    .AddInfrastructureDataAccess(configuration =>
    {
        configuration.Host = "localhost";
        configuration.Port = 6432;
        configuration.Username = "postgres";
        configuration.Password = "postgres";
        configuration.Database = "postgres";
        configuration.SslMode = "Prefer";
    })
    .AddPresentationConsole();

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();

scope.UseInfrastructureDataAccess();

WelcomeScenarioRunner welcomeScenarioRunner = scope.ServiceProvider
    .GetRequiredService<WelcomeScenarioRunner>();

while (true)
{
    welcomeScenarioRunner.Run();
    AnsiConsole.Clear();
}