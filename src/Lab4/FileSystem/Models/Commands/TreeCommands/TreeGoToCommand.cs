namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

public class TreeGoToCommand : ICommand
{
    private readonly string _path;

    public TreeGoToCommand(string path)
    {
        _path = path;
    }

    public void Execute(ref string address)
    {
        address = _path;
    }
}