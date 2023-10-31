using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public interface IMessageEndPoint
{
    ICollection<Message> Messages { get; }
    void Save(Message message);
}