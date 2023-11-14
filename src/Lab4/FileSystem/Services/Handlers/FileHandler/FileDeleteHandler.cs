using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileDeleteHandler : AbstractParserHandler
{
    private const string ComparableCommand = "delete";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private string? _path;
    public override void Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            _path = request.GetElement(PathIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}