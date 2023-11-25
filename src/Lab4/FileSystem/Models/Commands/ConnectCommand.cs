namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class ConnectCommand : ICommand
{
    private const string LocalMode = "local";
    private readonly string _newValue;
    private readonly string _mode;

    public ConnectCommand(string newValue, string mode)
    {
        _newValue = newValue;
        _mode = mode;
    }

    public IStrategy? Strategy { get; private set; }

    public void Execute(ref string address, IStrategy strategy)
    {
        if (Equals(LocalMode, _mode) && strategy is not LocalStrategy)
        {
            Strategy = new LocalStrategy();
        }

        Strategy?.Connect(ref address, _newValue);
    }
}