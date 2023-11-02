using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IAddressee> _addressees = new List<IAddressee>();
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public AddresseeGroup(ILogger logger)
    {
        _logger = logger;
    }

    public void Receive(Message message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
            {
                addressee.Receive(message);
                _logger.LogInformation($"A group of addressees received its message: {message.Body}");
            }
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