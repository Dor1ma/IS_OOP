using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.Withdrawal;

public class WithdrawalScenario : IScenario
{
    private readonly IUserService _userService;

    public WithdrawalScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Withdrawal";

    public void Run()
    {
        decimal request = AnsiConsole.Ask<decimal>("Enter the amount of funds you want to withdraw");
        _userService.Withdrawal(request);

        decimal? result = _userService.GetAccountValue();
        if (result is null)
        {
            AnsiConsole.WriteLine("Something went wrong");
            return;
        }

        AnsiConsole.WriteLine($"You withdrawn {request}. Your current account balance is: {result}");
    }
}