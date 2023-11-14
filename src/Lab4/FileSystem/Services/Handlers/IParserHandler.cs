using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public interface IParserHandler
{
    void SetNext(IParserHandler handler);
    void Handle(Request request);
}