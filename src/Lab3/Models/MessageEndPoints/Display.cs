using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Display : IMessageEndPoint
{
    private const int MessagesCapacity = 1;
    public ICollection<Message> Messages { get; } = new List<Message>(MessagesCapacity);
    public static void ShowTextByColor(Message message, Color color)
    {
        Console.WriteLine(message.Body, color);
    }

    public void Save(Message message)
    {
        Messages.Clear();
        Messages.Add(message);
    }
}