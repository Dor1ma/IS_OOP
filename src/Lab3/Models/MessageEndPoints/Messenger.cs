using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Messenger : IMessageEndPoint
{
    public ICollection<Message> Messages { get; } = new List<Message>();
    public static void ShowText(Message message)
    {
        Console.WriteLine(message.Body, "MESSENGER");
    }

    public void Save(Message message)
    {
        Messages.Add(message);
    }
}