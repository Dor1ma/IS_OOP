namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

public class TreeGoToCommand : ICommand
{
    private readonly string _path;
    private IStrategy? _concreteStrategy;

    public TreeGoToCommand(string path)
    {
        _path = path;
    }

    public void SetUpStrategy(IStrategy strategy)
    {
        _concreteStrategy = strategy;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        _concreteStrategy?.TreeGoTo(ref address, _path);
    }
}