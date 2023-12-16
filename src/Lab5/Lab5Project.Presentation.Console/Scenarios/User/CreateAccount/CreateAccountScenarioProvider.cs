using System.Diagnostics.CodeAnalysis;
using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Presentation.Console.Scenarios.User.CreateAccount;

public class CreateAccountScenarioProvider : IWelcomeScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public CreateAccountScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IWelcomeScenario? scenario)
    {
        if (_currentUser.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new CreateAccountScenario(_service);
        return true;
    }
}