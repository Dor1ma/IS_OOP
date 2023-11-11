using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class User : IUser
{
    private ICollection<Message> _readMessages = new List<Message>();
    public ICollection<Message> Messages { get; } = new List<Message>();

    public void Save(Message message)
    {
        Messages.Add(message);
    }

    public MarkingResults MarkConcreteAsRead(Message message)
    {
        if (_readMessages.Contains(message))
        {
            return MarkingResults.CannotMarkAsReadThisMessageBecauseItIsAlreadyRead;
        }

        _readMessages.Add(message);
        return MarkingResults.Success;
    }

    public MarkingResults MarkAllAsRead()
    {
        foreach (Message message in Messages)
        {
            if (_readMessages.Contains(message))
            {
                return MarkingResults.CannotMarkAsReadThisMessageBecauseItIsAlreadyRead;
            }

            _readMessages.Add(message);
        }

        return MarkingResults.Success;
    }

    public void MarkAllAsUnread()
    {
        foreach (Message message in _readMessages)
        {
            _readMessages.Remove(message);
        }
    }
}