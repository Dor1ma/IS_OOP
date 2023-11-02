using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly ICollection<IMessageEndPoint> _addressees = new List<IMessageEndPoint>();
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public AddresseeGroup(IMessageEndPoint firstAddressee, ILogger logger)
    {
        Addressee = firstAddressee;
        _addressees.Add(Addressee);
        _logger = logger;
    }

    public IMessageEndPoint Addressee { get; }

    public void Receive(Message message)
    {
        foreach (IMessageEndPoint addressee in _addressees)
        {
            if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
            {
                addressee.Save(message);
                _logger.LogInformation($"A group of addressees received its message: {message.Body}");
            }
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }

    public void AddAddressee(IMessageEndPoint addressee)
    {
        _addressees.Add(addressee);
    }
}