using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.Replenishment;

public class ReplenishmentScenario : IScenario
{
    private readonly IUserService _userService;

    public ReplenishmentScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Replenishment";

    public void Run()
    {
        decimal request = AnsiConsole.Ask<decimal>("Enter the amount of funds you want to replenish");
        _userService.Replenishment(request);

        decimal? result = _userService.GetAccountValue();
        if (result is null)
        {
            AnsiConsole.WriteLine("Something went wrong");
            return;
        }

        AnsiConsole.WriteLine($"You funded your account by {request}. Your current account balance is: {result}");
    }
}