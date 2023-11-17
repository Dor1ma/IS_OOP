using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.Tree;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void Execute(ref string address)
    {
        Walk(address, _depth);
    }

    private static void Walk(string root, int depth)
    {
        var dirs = new Stack<string>(depth);
        if (!Directory.Exists(root))
        {
            Console.WriteLine("Non-existent directory");
        }

        dirs.Push(root);
        while (dirs.Count > 0)
        {
            string currentDir = dirs.Pop();
            List<string> subDirs;
            try
            {
                subDirs = new List<string>(Directory.GetDirectories(currentDir));
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            List<string> files;
            try
            {
                files = new List<string>(Directory.GetFiles(currentDir));
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            foreach (string file in files)
            {
                try
                {
                    var fileInfo = new FileInfo(file);
                    Console.WriteLine("{0}: {1}, {2}", fileInfo.Name, fileInfo.Length, fileInfo.CreationTime);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            foreach (string str in subDirs)
                dirs.Push(str);
        }
    }
}