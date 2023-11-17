using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public class ConnectHandler : AbstractParserHandler
{
    private const string ToCompare = "connect";
    private const string ModeValue = "local";
    private const int CommandIndex = 0;
    private const int AddressIndex = 1;
    private const int ModeIndex = 3;
    private string? _mode;
    private ICommand? _connectCommand;
    public override ICommand? Handle(Request request)
    {
        if (Equals(request.GetElement(CommandIndex), ToCompare))
        {
            _connectCommand = new ConnectCommand(request.GetElement(AddressIndex));
            _mode = request.GetElement(ModeIndex);
            if (Equals(_mode, ModeValue))
            {
                return _connectCommand;
            }
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }

        return null;
    }
}