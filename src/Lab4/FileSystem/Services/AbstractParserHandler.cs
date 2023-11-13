namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public abstract class AbstractParserHandler : IParserHandler
{
    private IParserHandler? _parserHandler;

    public void SetNext(IParserHandler handler)
    {
        if (_parserHandler is not null)
        {
            _parserHandler.SetNext(handler);
        }
        else
        {
            _parserHandler = handler;
        }
    }

    public abstract void Handle(Request request);
}