using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileShowHandler : AbstractParserHandler
{
    private const string ComparableCommand = "show";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private const int ModeIndex = 4;
    private string? _path;
    private string? _mode;
    private ICommand? _fileShowCommand;
    public override ICommand? Handle(ConsoleRequest request)
    {
        if (Equals(request.GetElement(ComparableIndex), ComparableCommand))
        {
            _path = request.GetElement(PathIndex);
            _mode = request.GetElement(ModeIndex);
            _fileShowCommand = new FileShowCommand(_path, _mode);
            return _fileShowCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}