namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly int _depth;
    private IStrategy? _concreteStrategy;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void SetUpStrategy(IStrategy strategy)
    {
        _concreteStrategy = strategy;
    }

    public void Execute(ref string address)
    {
        _concreteStrategy?.TreeList(ref address, _depth, string.Empty);
    }
}