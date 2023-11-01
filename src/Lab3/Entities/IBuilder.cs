using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public interface IBuilder
{
    IBuilder WithHeader(string header);
    IBuilder WithBody(string body);
    IBuilder WithPriority(PriorityLevels priorityLevel);
    Message Build();
}