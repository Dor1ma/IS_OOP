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

    public void TreeList(ref string address, int depth, string indent)
    {
        if (depth < 0)
        {
            return;
        }

        var files = new List<string>(Directory.GetFiles(address));

        foreach (string file in files)
        {
            Console.WriteLine($"{indent}// {Path.GetFileName(file)}");
        }

        var subDirectories = new List<string>(Directory.GetDirectories(address));

        foreach (string directory in subDirectories)
        {
            Console.WriteLine($"{indent}$ {Path.GetFileName(directory)}");
            string refDirectory = directory;
            TreeList(ref refDirectory, depth - 1, indent + "--- ");
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
        const string consoleMode = "console";
        IPrintMethod printMethod;
        if (mode == consoleMode)
        {
            printMethod = new ConsolePrintMethod();
            string fullPath = Path.Combine(address, path);

            if (File.Exists(fullPath))
            {
                var readText = new List<string>(File.ReadAllLines(fullPath));
                foreach (string s in readText)
                {
                    printMethod.PrintText(s);
                }
            }
        }
    }
}