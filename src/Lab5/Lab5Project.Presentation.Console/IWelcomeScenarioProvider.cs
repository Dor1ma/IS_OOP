using System.Diagnostics.CodeAnalysis;

namespace Lab5Project.Presentation.Console;

public interface IWelcomeScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out IWelcomeScenario? scenario);
}