using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;

public class TreeHandler : AbstractParserHandler
{
    private const string Comparable = "tree";
    private const int CommandIndex = 0;

    public TreeHandler()
    {
        var treeGoToHandler = new TreeGoToHandler();
        var treeListHandler = new TreeListHandler();
        treeGoToHandler.SetNext(treeListHandler);
        SubHandler = treeGoToHandler;
    }

    private IParserHandler SubHandler { get; }
    public override void Handle(Request request)
    {
        if (request.GetElement(CommandIndex) == Comparable)
        {
            SubHandler.Handle(request);
        }
        else
        {
            NextParserHandler?.Handle(request);
        }
    }
}