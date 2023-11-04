using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public interface IAddressee
{
    public IMessageEndPoint ConcreteAddressee { get; }
    void Receive(Message message);
}