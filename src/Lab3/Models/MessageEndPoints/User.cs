using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class User : IMessageEndPoint
{
    public ICollection<Message> Messages { get; } = new List<Message>();

    public void Save(Message message)
    {
        message.MarkAsUnread();
        Messages.Add(message);
    }

    public void MarkAllAsRead()
    {
        foreach (Message message in Messages)
        {
            message.MarkAsRead();
        }
    }

    public void MarkAllAsUnread()
    {
        foreach (Message message in Messages)
        {
            message.MarkAsUnread();
        }
    }
}