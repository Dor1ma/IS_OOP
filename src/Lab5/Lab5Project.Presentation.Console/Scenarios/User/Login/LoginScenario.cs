using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.Login;

public class LoginScenario : IWelcomeScenario
{
    private readonly IUserService _userService;
    private readonly ScenarioRunner _scenarioRunner;

    public LoginScenario(IUserService userService, ScenarioRunner scenarioRunner)
    {
        _userService = userService;
        _scenarioRunner = scenarioRunner;
    }

    public string Name => "Login as user";

    public void Run()
    {
        string username = AnsiConsole.Ask<string>("Enter your username");
        int pin = AnsiConsole.Ask<int>("Enter your pin");

        LoginResult result = _userService.LoginResult(username, pin);

        string message = result switch
        {
            LoginResult.Success => "Successful login",
            LoginResult.NotFound => "User not found or incorrect data",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("Now, choose needed option");

        while (true)
        {
            _scenarioRunner.Run();
        }
    }
}