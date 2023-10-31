using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IAddressee> _addressees = new List<IAddressee>();

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