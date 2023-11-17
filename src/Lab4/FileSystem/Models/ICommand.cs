namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;

public interface ICommand
{
    void Execute(ref string address);
}