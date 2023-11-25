namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class DisconnectCommand : ICommand
{
    private IStrategy? _concreteStrategy;

    public void Execute(ref string address, IStrategy strategy)
    {
        _concreteStrategy = strategy;
        _concreteStrategy?.Disconnect(ref address);
    }
}