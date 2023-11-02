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
        ConcreteAddressee = firstAddressee;
        _addressees.Add(ConcreteAddressee);
        _logger = logger;
    }

    public IMessageEndPoint ConcreteAddressee { get; }

    public void Receive(Message message)
    {
        foreach (IMessageEndPoint addressee in _addressees)
        {
            if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
            {
                addressee.Save(message);
                _logger.LogInformation($"A group of addressees received its message: {message.Body}");
            }
            else
            {
                _logger.LogInformation($"A group of addressees didn't receive message: {message.Body}" +
                                       $"Reason: filter mismatch");
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