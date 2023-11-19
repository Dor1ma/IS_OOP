using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;

public interface ICommand
{
    void SetUpStrategy(IStrategy strategy);
    void Execute(ref string address);
}