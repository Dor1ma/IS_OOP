namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileRenameCommand : ICommand
{
    private readonly string _path;
    private readonly string _name;

    public FileRenameCommand(string path, string name)
    {
        _path = path;
        _name = name;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.FileRename(ref address, _path, _name);
    }
}