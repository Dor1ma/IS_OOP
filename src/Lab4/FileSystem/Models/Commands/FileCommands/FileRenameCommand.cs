using System;
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
        string pathforFile = Path.Combine(address, _path);
        string destinationDirectory = pathforFile.Replace(Path.GetFileNameWithoutExtension(pathforFile), _name, StringComparison.Ordinal);

        File.Move(pathforFile, destinationDirectory);
    }
}