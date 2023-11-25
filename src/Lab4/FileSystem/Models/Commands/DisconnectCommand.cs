namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class DisconnectCommand : ICommand
{
    private IStrategy? _concreteStrategy;

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.Disconnect(ref address);
        _concreteStrategy = strategy;
        _concreteStrategy?.Disconnect(ref address);
    }
}