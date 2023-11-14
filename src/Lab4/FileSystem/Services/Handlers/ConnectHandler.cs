using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public class ConnectHandler : AbstractParserHandler
{
    private const string ToCompare = "connect";
    private const int CommandIndex = 0;
    private const int AddressIndex = 1;
    private const int ModeIndex = 3;
    private string? _address;
    private string? _mode;
    public override void Handle(Request request)
    {
        if (request.GetElement(CommandIndex) == ToCompare)
        {
            _address = request.GetElement(AddressIndex);
            _mode = request.GetElement(ModeIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}