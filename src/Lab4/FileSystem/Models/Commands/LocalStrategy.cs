using System;
using System.Collections.Generic;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class LocalStrategy : IStrategy
{
    public void Connect(ref string address, string newValue)
    {
        address = newValue;
    }

    public void Disconnect(ref string address)
    {
        const int exitCode = 0;
        address = string.Empty;
        Environment.Exit(exitCode);
    }

    public void TreeGoTo(ref string address, string path)
    {
        address = path;
    }

    public void TreeList(ref string address, int depth)
    {
        try
        {
            var dirs = new List<string>(Directory.EnumerateDirectories(address));

            foreach (string dir in dirs)
            {
                Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
            }

            Console.WriteLine($"{dirs.Count} Amount of directories.");
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

    public void FileCopy(ref string address, string sourcePath, string destinationPath)
    {
        string sourceFullPath = Path.Combine(address, sourcePath);
        string destinationFullPath = Path.Combine(address, destinationPath);

        if (File.Exists(sourceFullPath))
        {
            File.Copy(sourceFullPath, destinationFullPath);
        }
    }

    public void FileDelete(ref string address, string path)
    {
        string fullPath = Path.Combine(address, path);
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }

    public void FileMove(ref string address, string sourcePath, string destinationPath)
    {
        string sourceFullPath = Path.Combine(address, sourcePath);
        string destinationFullPath = Path.Combine(address, destinationPath);
        if (File.Exists(sourceFullPath))
        {
            File.Move(sourceFullPath, destinationFullPath);
        }
    }

    public void FileRename(ref string address, string path, string name)
    {
        string pathForFile = Path.Combine(address, path);
        string destinationDirectory = pathForFile.Replace(Path.GetFileNameWithoutExtension(pathForFile), name, StringComparison.Ordinal);

        File.Move(pathForFile, destinationDirectory);
    }

    public void FileShow(ref string address, string path, string mode)
    {
        string fullPath = Path.Combine(address, path);

        if (File.Exists(fullPath))
        {
            Console.WriteLine($"Showing info of file {fullPath} in mode {mode}");
        }
    }
}