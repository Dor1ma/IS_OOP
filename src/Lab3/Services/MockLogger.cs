using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class MockLogger : ILogger
{
    public string? Message { get; private set; }
    public void LogInformation(string message)
    {
        Message = message;
        Console.WriteLine(message);
    }
}