namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileCopyCommand : ICommand
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;
    private IStrategy? _concreteStrategy;

    public FileCopyCommand(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        _concreteStrategy = strategy;
        _concreteStrategy?.FileCopy(ref address, _sourcePath, _destinationPath);
    }
}