using Spectre.Console;

namespace Lab5Project.Presentation.Console;

public class WelcomeScenarioRunner
{
    private readonly IEnumerable<IWelcomeScenarioProvider> _providers;

    public WelcomeScenarioRunner(IEnumerable<IWelcomeScenarioProvider> providers)
    {
        _providers = providers;
    }

    public void Run()
    {
        IEnumerable<IWelcomeScenario> scenarios = GetScenarios();

        SelectionPrompt<IWelcomeScenario> selector = new SelectionPrompt<IWelcomeScenario>()
            .Title("Select action")
            .AddChoices(scenarios)
            .UseConverter(x => x.Name);

        IWelcomeScenario scenario = AnsiConsole.Prompt(selector);
        scenario.Run();
    }

    private IEnumerable<IWelcomeScenario> GetScenarios()
    {
        foreach (IWelcomeScenarioProvider provider in _providers)
        {
            if (provider.TryGetScenario(out IWelcomeScenario? scenario))
                yield return scenario;
        }
    }
}