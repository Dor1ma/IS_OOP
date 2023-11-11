using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeMessenger : IAddressee
{
    public AddresseeMessenger(IMessenger messenger)
    {
        ConcreteAddressee = messenger;
    }

    public IMessenger ConcreteAddressee { get; private set; }

    public void Receive(Message message)
    {
        ConcreteAddressee.Save(message);
    }
}