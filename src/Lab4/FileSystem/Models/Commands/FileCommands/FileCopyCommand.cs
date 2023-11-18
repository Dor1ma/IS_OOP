using System.IO;

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

    public void Execute(ref string address)
    {
        string sourceFullPath = Path.Combine(address, _sourcePath);
        string destinationFullPath = Path.Combine(address, _destinationPath);

        if (File.Exists(sourceFullPath))
        {
            File.Copy(sourceFullPath, destinationFullPath);
        }
    }
}