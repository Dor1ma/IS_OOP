namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileMoveCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    public FileMoveCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.FileMove(ref address, _sourcePath, _destinationPath);
    }
}