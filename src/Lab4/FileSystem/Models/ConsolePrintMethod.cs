using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;

public class ConsolePrintMethod : IPrintMethod
{
    public void PrintText(string context)
    {
        Console.WriteLine(context);
    }
}