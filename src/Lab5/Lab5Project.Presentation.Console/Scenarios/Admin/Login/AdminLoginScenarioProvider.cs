using System.Diagnostics.CodeAnalysis;
using Lab5Project.Application.Contracts.Admins;

namespace Lab5Project.Presentation.Console.Scenarios.Admin.Login;

public class AdminLoginScenarioProvider : IWelcomeScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentAdminService _currentAdmin;

    public AdminLoginScenarioProvider(
        IAdminService service,
        ICurrentAdminService currentAdmin)
    {
        _service = service;
        _currentAdmin = currentAdmin;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IWelcomeScenario? scenario)
    {
        if (_currentAdmin.Admin is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new AdminLoginScenario(_service);
        return true;
    }
}