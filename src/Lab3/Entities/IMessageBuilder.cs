using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public interface IMessageBuilder
{
    IMessageBuilder WithHeader(string header);
    IMessageBuilder WithBody(string body);
    IMessageBuilder WithPriority(PriorityLevels priorityLevel);
    Message Build();
}