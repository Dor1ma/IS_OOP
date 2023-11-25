namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileShowCommand : ICommand
{
    private readonly string _path;
    private readonly string _mode;
    private IStrategy? _concreteStrategy;

    public FileShowCommand(string path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        _concreteStrategy = strategy;
        _concreteStrategy?.FileShow(ref address, _path, _mode);
    }
}