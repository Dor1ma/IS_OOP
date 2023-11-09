using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public interface IMessenger
{
    public ICollection<Message> Messages { get; }
    void Save(Message message);
}