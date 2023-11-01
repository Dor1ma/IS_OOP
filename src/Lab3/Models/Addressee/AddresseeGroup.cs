using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IAddressee> _addressees = new List<IAddressee>();
    private PriorityLevels _filter = PriorityLevels.None;

    public void Receive(Message message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
                addressee.Receive(message);
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }

    public void AddAddressee(IAddressee addressee)
    {
        _addressees.Add(addressee);
    }
}