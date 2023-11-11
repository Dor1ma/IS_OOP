using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockMessenger : IMessageEndPoint
{
    private const string Postscript = " MESSENGER";
    public string? ShowingResult { get; private set; }
    public ICollection<Message> Messages { get; } = new List<Message>();

    public void ShowText(Message message)
    {
        ShowingResult = $"{message.Body}" + Postscript;
        Console.WriteLine($"{message.Body}" + Postscript);
    }

    public void Save(Message message)
    {
        Messages.Add(message);
    }
}