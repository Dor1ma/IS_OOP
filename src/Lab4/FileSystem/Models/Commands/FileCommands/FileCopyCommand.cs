namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileCopyCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;

    public FileCopyCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.FileCopy(ref address, _sourcePath, _destinationPath);
    }
}