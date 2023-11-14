namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public abstract class AbstractParserHandler : IParserHandler
{
    protected IParserHandler? ParserHandler { get; private set; }
    public void SetNext(IParserHandler handler)
    {
        if (ParserHandler is not null)
        {
            ParserHandler.SetNext(handler);
        }
        else
        {
            ParserHandler = handler;
        }
    }

    public abstract void Handle(Request request);
}