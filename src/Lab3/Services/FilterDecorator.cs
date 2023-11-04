using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class FilterDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly PriorityLevels _filter;

    public FilterDecorator(IAddressee addressee, PriorityLevels filter)
    {
        _addressee = addressee;
        _filter = filter;
        ConcreteAddressee = _addressee.ConcreteAddressee;
    }

    public IMessageEndPoint ConcreteAddressee { get; }
    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            ConcreteAddressee.Save(message);
        }
    }
}