using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileMoveHandler : AbstractParserHandler
{
    private const string ComparableCommand = "move";
    private const int ComparableIndex = 1;
    private const int SourcePathIndex = 2;
    private const int DestinationPathIndex = 3;
    private string? _sourcePath;
    private string? _destinationPath;
    private ICommand? _fileMoveCommand;
    public override ICommand? Handle(ConsoleRequest request)
    {
        if (Equals(request.GetElement(ComparableIndex), ComparableCommand))
        {
            _sourcePath = request.GetElement(SourcePathIndex);
            _destinationPath = request.GetElement(DestinationPathIndex);
            _fileMoveCommand = new FileMoveCommand(_sourcePath, _destinationPath);
            return _fileMoveCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}