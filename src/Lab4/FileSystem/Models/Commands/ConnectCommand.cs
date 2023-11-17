namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class ConnectCommand : ICommand
{
    private readonly string _newValue;

    public ConnectCommand(string newValue)
    {
        _newValue = newValue;
    }

    public void Execute(ref string address)
    {
        address = _newValue;
    }
}