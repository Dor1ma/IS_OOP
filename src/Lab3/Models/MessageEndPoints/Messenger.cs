using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Messenger : IMessenger
{
    private const string Postscript = " MESSENGER";
    public ICollection<Message> Messages { get; } = new List<Message>();
    public static void ShowText(Message message)
    {
        Console.WriteLine($"{message.Body}" + Postscript);
    }

    public void Save(Message message)
    {
        Messages.Add(message);
    }
}