using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class User : IMessageEndPoint
{
    public ICollection<Message> Messages { get; } = new List<Message>();

    public void Save(Message message)
    {
        message.MarkAsUnread();
        Messages.Add(message);
    }

    public MarkingResults MarkAllAsRead()
    {
        foreach (Message message in Messages)
        {
            if (message.Status is Status.Read)
            {
                return MarkingResults.CannotMarkAsReadThisMessageBecauseItIsAlreadyRead;
            }

            message.MarkAsRead();
        }

        return MarkingResults.Success;
    }

    public void MarkAllAsUnread()
    {
        foreach (Message message in Messages)
        {
            message.MarkAsUnread();
        }
    }
}