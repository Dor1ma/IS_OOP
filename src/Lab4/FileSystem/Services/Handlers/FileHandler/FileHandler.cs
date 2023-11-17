using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;

public class FileHandler : AbstractParserHandler
{
    private const string Comparable = "file";
    private const int MainComparableIndex = 0;

    public FileHandler()
    {
        var fileCopyHandler = new FileCopyHandler();
        var fileDeleteHandler = new FileDeleteHandler();
        var fileMoveHandler = new FileMoveHandler();
        var fileRenameHandler = new FileRenameHandler();
        var fileShowHandler = new FileShowHandler();
        fileCopyHandler.SetNext(fileDeleteHandler);
        fileDeleteHandler.SetNext(fileMoveHandler);
        fileMoveHandler.SetNext(fileRenameHandler);
        fileRenameHandler.SetNext(fileShowHandler);
        SubParserHandler = fileCopyHandler;
    }

    private IParserHandler? SubParserHandler { get; }
    public override ICommand? Handle(Request request)
    {
        if (Equals(request.GetElement(MainComparableIndex), Comparable))
        {
            return SubParserHandler?.Handle(request);
        }
        else
        {
            return NextParserHandler?.Handle(request);
        }
    }
}