using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileShowHandler : AbstractParserHandler
{
    private const string ComparableCommand = "show";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private const int ModeIndex = 4;
    private string? _path;
    private string? _mode;
    public override void Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            _path = request.GetElement(PathIndex);
            _mode = request.GetElement(ModeIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}