using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

public class ConsoleRequest : IRequest
{
    private readonly IList<string> _request;

    public ConsoleRequest(string request)
    {
        _request = request.Split(' ');
    }

    public string GetElement(int index)
    {
        return _request[index];
    }
}