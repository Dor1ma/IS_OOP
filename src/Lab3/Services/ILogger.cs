using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface ILogger
{
    void LogInformation(Message message);
}