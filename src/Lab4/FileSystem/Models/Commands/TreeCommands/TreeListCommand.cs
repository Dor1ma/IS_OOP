namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void Execute(ref string address, IStrategy strategy)
    {
        strategy.TreeList(ref address, _depth, string.Empty);
    }
}