using System;
using System.Collections.Generic;

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