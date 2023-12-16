using Lab5Project.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5Project.Presentation.Console.Scenarios.User.OperationsHistory;

public class OperationsHistoryScenario : IScenario
{
    private readonly IUserService _userService;

    public OperationsHistoryScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Show operations history";

    public void Run()
    {
        IEnumerable<Operation>? operations = _userService.GetOperationsHistory();

        if (operations is null)
        {
            AnsiConsole.WriteLine("Something went wrong");
            return;
        }

        AnsiConsole.WriteLine("Your operations history is:");
        foreach (Operation operation in operations)
        {
            AnsiConsole.WriteLine($"{operation.AccountNumber}, {operation.OperationType}, {operation.Value}");
        }
    }
}