using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileRenameHandler : AbstractParserHandler
{
    private const string ComparableCommand = "rename";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private const int NameIndex = 3;
    private string? _path;
    private string? _name;
    private ICommand? _fileRenameCommand;
    public override ICommand? Handle(Request request)
    {
        if (Equals(request.GetElement(ComparableIndex), ComparableCommand))
        {
            _path = request.GetElement(PathIndex);
            _name = request.GetElement(NameIndex);
            _fileRenameCommand = new FileRenameCommand(_path, _name);
            return _fileRenameCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}