namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services;

public interface IParserHandler
{
    void SetNext(IParserHandler handler);
    void Handle(Request request);
}