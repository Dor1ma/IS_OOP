using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;

public class TreeGoToHandler : AbstractParserHandler
{
    private const string ComparableCommand = "goto";
    private const int ComparableIndex = 1;
    private const int PathIndex = 2;
    private string? _path;
    private ICommand? _treeGoToCommand;
    public override ICommand? Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            _path = request.GetElement(PathIndex);
            _treeGoToCommand = new TreeGoToCommand(_path);
            return _treeGoToCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}