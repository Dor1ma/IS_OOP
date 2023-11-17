using System;
using System.IO;

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

    public void Execute(ref string address)
    {
        string fullPath = Path.Combine(address, _path);

        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Showing info of file {fullPath} in mode {_mode}");
        }
    }
}