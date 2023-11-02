using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class MessageBuilder : IMessageBuilder
{
    private string _header = string.Empty;
    private string _body = string.Empty;
    private PriorityLevels _priorityLevel = PriorityLevels.None;

    public IMessageBuilder WithHeader(string header)
    {
        _header = header;
        return this;
    }

    public IMessageBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public IMessageBuilder WithPriority(PriorityLevels priorityLevel)
    {
        _priorityLevel = priorityLevel;
        return this;
    }

    public Message Build()
    {
        return new Message(_header, _body, _priorityLevel);
    }
}