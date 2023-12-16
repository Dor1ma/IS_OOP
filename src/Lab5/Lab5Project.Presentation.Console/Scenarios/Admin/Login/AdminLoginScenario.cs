using Lab5Project.Application.Contracts.Admins;
using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.Admin.Login;

public class AdminLoginScenario : IWelcomeScenario
{
    private readonly IAdminService _adminService;

    public AdminLoginScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Login as admin";

    public void Run()
    {
        string username = AnsiConsole.Ask<string>("Enter your username");
        string pin = AnsiConsole.Ask<string>("Enter you password");

        LoginResult result = _adminService.LoginResult(username, pin);

        string message = result switch
        {
            LoginResult.Success => "Successful login as admin",
            LoginResult.NotFound => "Admin not found or incorrect data",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
    }
}