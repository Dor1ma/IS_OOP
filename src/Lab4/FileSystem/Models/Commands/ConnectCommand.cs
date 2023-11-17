namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public class ConnectCommand : ICommand
{
    private readonly string _newValue;

    public ConnectCommand(string newValue)
    {
        _newValue = newValue;
    }

    public string? Value { get; private set; }

    public void Execute(ref string address)
    {
        Value = address;
        Update();
    }

    private void Update()
    {
        Value = _newValue;
    }
}