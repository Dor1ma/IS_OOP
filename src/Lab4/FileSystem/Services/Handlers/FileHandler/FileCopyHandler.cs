using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileCopyHandler : AbstractParserHandler
{
    private const string ComparableCommand = "copy";
    private const int ComparableIndex = 1;
    private const int SourcePathIndex = 2;
    private const int DestinationPathIndex = 3;
    private string? _sourcePath;
    private string? _destinationPath;
    public override void Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            _sourcePath = request.GetElement(SourcePathIndex);
            _destinationPath = request.GetElement(DestinationPathIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}