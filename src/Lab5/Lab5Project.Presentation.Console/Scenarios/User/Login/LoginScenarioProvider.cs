using System.Diagnostics.CodeAnalysis;
using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Presentation.Console.Scenarios.User.Login;

public class LoginScenarioProvider : IWelcomeScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;
    private readonly ScenarioRunner _scenarioRunner;

    public LoginScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser,
        ScenarioRunner scenarioRunner)
    {
        _service = service;
        _currentUser = currentUser;
        _scenarioRunner = scenarioRunner;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IWelcomeScenario? scenario)
    {
        if (_currentUser.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new LoginScenario(_service, _scenarioRunner);
        return true;
    }
}