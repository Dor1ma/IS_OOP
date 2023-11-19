namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class DisconnectCommand : ICommand
{
    private IStrategy? _concreteStrategy;
    public void SetUpStrategy(IStrategy strategy)
    {
        _concreteStrategy = strategy;
    }

    public void Execute(ref string address)
    {
        _concreteStrategy?.Disconnect(ref address);
    }
}