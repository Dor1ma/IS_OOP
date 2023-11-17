using System.IO;

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

    public void Execute(ref string address)
    {
        string fullPath = Path.Combine(address, _path + _name);

        if (File.Exists(fullPath))
        {
            int copyCount = 1;
            while (File.Exists(fullPath))
            {
                string newName = fullPath + "copy" + copyCount;
                File.Move(fullPath, newName);
                fullPath = newName;
            }
        }
    }
}