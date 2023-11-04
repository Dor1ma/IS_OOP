using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockLogger : ILogger
{
    public string? Message { get; private set; }
    public void LogInformation(string message)
    {
        Message = message;
        Console.WriteLine(message);
    }
}