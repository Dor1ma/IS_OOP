using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;

public interface IParserHandler
{
    void SetNext(IParserHandler handler);
    ICommand? Handle(ConsoleRequest request);
}