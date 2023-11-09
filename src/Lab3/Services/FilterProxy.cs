using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class FilterProxy : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly PriorityLevels _filter;

    public FilterProxy(IAddressee addressee, PriorityLevels filter)
    {
        _addressee = addressee;
        _filter = filter;
    }

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            _addressee.Receive(message);
        }
    }
}