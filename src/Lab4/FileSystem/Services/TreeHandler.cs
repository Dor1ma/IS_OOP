namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public class TreeHandler : AbstractParserHandler
{
    private const string Comparable = "tree";
    private const string SecondParameterComparable = "goto";
    private const int PathIndex = 2;
    private const int DepthIndex = 3;
    private const int CommandIndex = 0;
    private const int SecondParameterIndex = 1;
    private string? _path;
    private string? _depth;
    public override void Handle(Request request)
    {
        if (request.GetElement(CommandIndex) == Comparable)
        {
            if (request.GetElement(SecondParameterIndex) == SecondParameterComparable)
            {
                _path = request.GetElement(PathIndex);
            }
            else
            {
                _depth = request.GetElement(DepthIndex);
            }
        }
        else
        {
            ParserHandler?.Handle(request);
        }
    }
}