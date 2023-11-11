using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeDisplay : IAddressee
{
    public AddresseeDisplay(IDisplay display)
    {
        Display = display;
    }

    public IDisplay Display { get; private set; }

    public void Receive(Message message)
    {
        Display.Save(message);
    }
}