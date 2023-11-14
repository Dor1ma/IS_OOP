using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

public class Request
{
    private readonly IList<string> _request;

    public Request(string request)
    {
        _request = request.Split(' ');
    }

    public string GetElement(int index)
    {
        return _request[index];
    }
}