namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class ConnectCommand : ICommand
{
    private readonly string _newValue;
    private IStrategy? _concreteStrategy;

    public ConnectCommand(string newValue, string mode)
    {
        _newValue = newValue;
        Mode = mode;
    }

    public string Mode { get; private set; }
    public void SetUpStrategy(IStrategy strategy)
    {
        _concreteStrategy = strategy;
    }

    public void Execute(ref string address)
    {
        _concreteStrategy?.Connect(ref address, _newValue);
    }
}