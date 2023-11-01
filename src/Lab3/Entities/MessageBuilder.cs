using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class MessageBuilder : IBuilder
{
    private string _header = string.Empty;
    private string _body = string.Empty;
    private PriorityLevels _priorityLevel = PriorityLevels.None;

    public IBuilder WithHeader(string header)
    {
        _header = header;
        return this;
    }

    public IBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public IBuilder WithPriority(PriorityLevels priorityLevel)
    {
        _priorityLevel = priorityLevel;
        return this;
    }

    public Message Build()
    {
        return new Message(_header, _body, _priorityLevel);
    }
}