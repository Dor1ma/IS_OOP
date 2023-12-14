using System.Diagnostics.CodeAnalysis;

namespace Lab5Project.Presentation.Console;

public interface IScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario);
}