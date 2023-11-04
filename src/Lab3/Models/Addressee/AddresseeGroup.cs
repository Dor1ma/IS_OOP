using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IMessageEndPoint> _addressees = new List<IMessageEndPoint>();

    public AddresseeGroup(IMessageEndPoint firstAddressee)
    {
        ConcreteAddressee = firstAddressee;
        _addressees.Add(ConcreteAddressee);
    }

    public IMessageEndPoint ConcreteAddressee { get; }

    public void Receive(Message message)
    {
        foreach (IMessageEndPoint addressee in _addressees)
        {
            addressee.Save(message);
        }
    }

    public void AddAddressee(IMessageEndPoint addressee)
    {
        _addressees.Add(addressee);
    }
}