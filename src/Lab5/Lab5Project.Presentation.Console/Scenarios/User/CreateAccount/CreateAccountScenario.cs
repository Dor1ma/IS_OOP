using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.CreateAccount;

public class CreateAccountScenario : IWelcomeScenario
{
    private readonly IUserService _userService;

    public CreateAccountScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Create an account";

    public void Run()
    {
        string username = AnsiConsole.Ask<string>("Enter your username");
        int pin = AnsiConsole.Ask<int>("Enter you pin");

        _userService.CreateAccount(username, pin);

        AnsiConsole.WriteLine("You have successfully created your account");
        AnsiConsole.WriteLine("Now you have to login");
    }
}