using System.Diagnostics.CodeAnalysis;
using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Presentation.Console.Scenarios.User.ShowBalance;

public class ShowBalanceScenarioProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public ShowBalanceScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser.User is null)
        {
            scenario = null;
            return false;
        }

        scenario = new ShowBalanceScenario(_service);
        return true;
    }
}