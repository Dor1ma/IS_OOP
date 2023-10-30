using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class User : MessageEndPoint
{
    private readonly ICollection<Message> _receivedMessages = new List<Message>();

    public void ReceiveMessage(Message message)
    {
        message.MarkAsUnread();
        _receivedMessages.Add(message);
    }

    public void MarkAllAsRead()
    {
        foreach (Message message in _receivedMessages)
        {
            message.MarkAsRead();
        }
    }

    public void MarkAllAsUnread()
    {
        foreach (Message message in _receivedMessages)
        {
            message.MarkAsUnread();
        }
    }
}