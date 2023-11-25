namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileShowCommand : ICommand
{
    private readonly string _path;
    private readonly string _mode;

    public FileShowCommand(string path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.FileShow(ref address, _path, _mode);
    }
}