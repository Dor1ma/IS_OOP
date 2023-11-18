using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.TreeCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;

public class TreeListHandler : AbstractParserHandler
{
    private const string ComparableCommand = "list";
    private const int ComparableIndex = 1;
    private const int DepthIndex = 3;
    private int? _depth;
    private ICommand? _treeListCommand;
    public override ICommand? Handle(Request request)
    {
        if (request.GetElement(ComparableIndex) == ComparableCommand)
        {
            string stringDepth = request.GetElement(DepthIndex);
            _depth = int.Parse(stringDepth, System.Globalization.CultureInfo.InvariantCulture);
            _treeListCommand = new TreeListCommand((int)_depth);
            return _treeListCommand;
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}