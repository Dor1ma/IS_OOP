using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeUser : IAddressee
{
    public AddresseeUser(IUser concreteAddressee)
    {
        ConcreteAddressee = concreteAddressee;
    }

    public IUser ConcreteAddressee { get; }

    public void Receive(Message message)
    {
        ConcreteAddressee.Save(message);
    }
}