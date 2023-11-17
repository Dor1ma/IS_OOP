using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class DisconnectCommand : ICommand
{
    private const int ExitCode = 0;
    public void Execute(ref string address)
    {
        Environment.Exit(ExitCode);
    }
}