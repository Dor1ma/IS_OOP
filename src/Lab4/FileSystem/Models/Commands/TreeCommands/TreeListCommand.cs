using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly int _depth;
    private string? _address;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void Execute(ref string address)
    {
        _address = address;
        Walk();
    }

    private void Walk()
    {
        try
        {
            if (_address != null)
            {
                var dirs = new List<string>(Directory.EnumerateDirectories(_address));

                foreach (string dir in dirs)
                {
                    Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                }

                Console.WriteLine($"{dirs.Count} Amount of directories.");
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}