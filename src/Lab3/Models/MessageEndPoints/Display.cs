using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Display : IMessageEndPoint
{
    private const int MessagesCapacity = 1;
    private string? _messageText;
    public ICollection<Message> Messages { get; } = new List<Message>(MessagesCapacity);
    public void ShowTextByColor(ConsoleColor color)
    {
        if (_messageText is not null)
            Console.WriteLine(_messageText, color);
    }

    public void Save(Message message)
    {
        Messages.Add(message);
        _messageText = message.Body;
    }

    public void DeleteMessage()
    {
        Messages.Clear();
    }
}