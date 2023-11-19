namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileDeleteCommand : ICommand
{
    private readonly string _path;
    private IStrategy? _concreteStrategy;

    public FileDeleteCommand(string path)
    {
        _path = path;
    }

    public void SetUpStrategy(IStrategy strategy)
    {
        _concreteStrategy = strategy;
    }

    public void Execute(ref string address)
    {
        _concreteStrategy?.FileDelete(ref address, _path);
    }
}