using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeMessenger : IAddressee
{
    private readonly Messenger _messenger = new Messenger();
    public void Receive(Message message)
    {
        _messenger.Save(message);
    }
}