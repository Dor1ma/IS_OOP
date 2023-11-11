using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockLogger : ILogger
{
    public Message? Message { get; private set; }
    public void LogInformation(Message message)
    {
        Message = message;
        Console.WriteLine($"Received message: {Message.Body}");
    }
}