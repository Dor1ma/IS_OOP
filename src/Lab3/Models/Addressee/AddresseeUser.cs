using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeUser : IAddressee
{
    private readonly User _user = new User();
    public void Receive(Message message)
    {
        _user.Save(message);
    }
}