namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public class FileHandler : AbstractParserHandler
{
    private const string Comparable = "file";
    private const string ShowComparable = "show";
    private const string MoveComparable = "move";
    private const string CopyComparable = "copy";
    private const string DeleteComparable = "delete";
    private const string RenameComparable = "rename";
    private const int MainComparableIndex = 0;
    private const int CommandIndex = 1;
    private const int SourcePathIndex = 2;
    private const int PathIndex = 2;
    private const int DestinationPathIndex = 2;
    private const int NameIndex = 3;
    private const int ModeIndex = 4;
    private string? _sourcePath;
    private string? _destinationPath;
    private string? _path;
    private string? _name;
    private string? _mode;
    public override void Handle(Request request)
    {
        if (request.GetElement(MainComparableIndex) != Comparable)
        {
            ParserHandler?.Handle(request);
            return;
        }

        if (request.GetElement(CommandIndex) == ShowComparable)
        {
            _path = request.GetElement(PathIndex);
            _mode = request.GetElement(ModeIndex);
        }
        else if (request.GetElement(CommandIndex) == MoveComparable
                 || request.GetElement(CommandIndex) == CopyComparable)
        {
            _sourcePath = request.GetElement(SourcePathIndex);
            _destinationPath = request.GetElement(DestinationPathIndex);
        }
        else if (request.GetElement(CommandIndex) == DeleteComparable)
        {
            _path = request.GetElement(PathIndex);
        }
        else if (request.GetElement(CommandIndex) == RenameComparable)
        {
            _path = request.GetElement(PathIndex);
            _name = request.GetElement(NameIndex);
        }
    }
}