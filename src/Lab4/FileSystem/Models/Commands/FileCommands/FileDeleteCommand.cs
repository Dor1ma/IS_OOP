namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileDeleteCommand : ICommand
{
    private readonly string _path;

    public FileDeleteCommand(string path)
    {
        _path = path;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.FileDelete(ref address, _path);
    }
}