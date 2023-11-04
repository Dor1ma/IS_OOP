using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IAddressee> _addressees = new List<IAddressee>();

    public AddresseeGroup(IAddressee addressee)
    {
        ConcreteAddressee = addressee.ConcreteAddressee;
        _addressees.Add(addressee);
    }

    public IMessageEndPoint ConcreteAddressee { get; }

    public void Receive(Message message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.Receive(message);
        }
    }

    public void AddAddressee(IAddressee addressee)
    {
        _addressees.Add(addressee);
    }
}