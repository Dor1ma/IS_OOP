using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public abstract class AbstractParserHandler : IParserHandler
{
    protected IParserHandler? NextParserHandler { get; private set; }
    public void SetNext(IParserHandler handler)
    {
        if (NextParserHandler is not null)
        {
            NextParserHandler.SetNext(handler);
        }
        else
        {
            NextParserHandler = handler;
        }
    }

    public abstract void Handle(Request request);
}