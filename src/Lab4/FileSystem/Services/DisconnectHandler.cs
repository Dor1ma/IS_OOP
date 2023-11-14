namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public class DisconnectHandler : AbstractParserHandler
{
    private const string Comparable = "disconnect";
    private const int CommandIndex = 0;
    private string? _value;
    public override void Handle(Request request)
    {
        if (request.GetElement(CommandIndex) == Comparable)
        {
            _value = request.GetElement(CommandIndex);
        }
        else
        {
            ParserHandler?.Handle(request);
        }
    }
}