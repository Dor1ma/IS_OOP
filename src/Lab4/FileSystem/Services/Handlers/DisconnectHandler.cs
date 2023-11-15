using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public class DisconnectHandler : AbstractParserHandler
{
    private const string Comparable = "disconnect";
    private const int CommandIndex = 0;
    private string? _value;
    public override void Handle(Request request)
    {
        if (Equals(request.GetElement(CommandIndex), Comparable))
        {
            _value = request.GetElement(CommandIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}