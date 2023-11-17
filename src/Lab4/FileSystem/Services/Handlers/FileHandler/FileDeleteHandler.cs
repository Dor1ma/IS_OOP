using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileDeleteHandler : AbstractParserHandler
{
    private const string ComparableCommand = "delete";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private string? _path;
    private ICommand? _fileDeleteCommand;
    public override ICommand? Handle(Request request)
    {
        if (Equals(request.GetElement(ComparableIndex), ComparableCommand))
        {
            _path = request.GetElement(PathIndex);
            _fileDeleteCommand = new FileDeleteCommand(_path);
            return _fileDeleteCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}