using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public interface IAddressee
{
    public IMessageEndPoint Addressee { get; }
    void Receive(Message message);
    void SetupFilter(PriorityLevels priorityLevel);
}