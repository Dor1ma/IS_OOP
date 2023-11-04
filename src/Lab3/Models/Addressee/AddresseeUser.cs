using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeUser : IAddressee
{
    public IMessageEndPoint ConcreteAddressee { get; } = new User();

    public void Receive(Message message)
    {
        ConcreteAddressee.Save(message);
    }
}