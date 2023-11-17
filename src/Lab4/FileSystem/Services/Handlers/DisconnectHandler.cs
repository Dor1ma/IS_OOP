using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public class DisconnectHandler : AbstractParserHandler
{
    private const string Comparable = "disconnect";
    private const int CommandIndex = 0;
    private readonly ICommand _disconnectCommand = new DisconnectCommand();
    public override ICommand? Handle(Request request)
    {
        if (Equals(request.GetElement(CommandIndex), Comparable))
        {
            return _disconnectCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}