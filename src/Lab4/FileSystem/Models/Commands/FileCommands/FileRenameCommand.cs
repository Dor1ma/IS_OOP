namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileRenameCommand : ICommand
{
    private readonly string _path;
    private readonly string _name;
    private IStrategy? _concreteStrategy;

    public FileRenameCommand(string path, string name)
    {
        _path = path;
        _name = name;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        _concreteStrategy = strategy;
        _concreteStrategy?.FileRename(ref address, _path, _name);
    }
}