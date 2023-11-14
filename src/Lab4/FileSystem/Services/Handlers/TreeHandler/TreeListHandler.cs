using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;

public class TreeListHandler : AbstractParserHandler
{
    private const string ComparableCommand = "list";
    private const int ComparableIndex = 1;
    private const int DepthIndex = 3;
    private string? _depth;
    public override void Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            _depth = request.GetElement(DepthIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}