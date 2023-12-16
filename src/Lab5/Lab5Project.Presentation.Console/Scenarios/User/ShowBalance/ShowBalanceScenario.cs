using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.ShowBalance;

public class ShowBalanceScenario : IScenario
{
    private readonly IUserService _userService;

    public ShowBalanceScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Show account balance";

    public void Run()
    {
        decimal? result = _userService.GetAccountValue();

        if (result is null)
        {
            AnsiConsole.WriteLine("Something went wrong");
            return;
        }

        AnsiConsole.WriteLine($"Your balance account is: {result}");
    }
}