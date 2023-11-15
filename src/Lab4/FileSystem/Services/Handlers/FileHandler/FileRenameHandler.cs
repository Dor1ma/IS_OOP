using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileRenameHandler : AbstractParserHandler
{
    private const string ComparableCommand = "rename";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private const int NameIndex = 3;
    private string? _path;
    private string? _name;
    public override void Handle(Request request)
    {
        if (Equals(request.GetElement(ComparableIndex), ComparableCommand))
        {
            _path = request.GetElement(PathIndex);
            _name = request.GetElement(NameIndex);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}