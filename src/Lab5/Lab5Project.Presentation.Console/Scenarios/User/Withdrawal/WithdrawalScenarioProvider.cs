using System.Diagnostics.CodeAnalysis;
using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Presentation.Console.Scenarios.User.Withdrawal;

public class WithdrawalScenarioProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public WithdrawalScenarioProvider(
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

        scenario = new WithdrawalScenario(_service);
        return true;
    }
}