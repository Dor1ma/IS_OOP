using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

public class FileDeleteCommand : ICommand
{
    private readonly string _path;

    public FileDeleteCommand(string path)
    {
        _path = path;
    }

    public void Execute(ref string address)
    {
        string fullPath = Path.Combine(address, _path);
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }
}