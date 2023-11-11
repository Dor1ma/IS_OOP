using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockDecoratedFilter : IAddressee
{
    private readonly PriorityLevels _filter;

    public MockDecoratedFilter(IAddressee addressee, PriorityLevels filter)
    {
        Addressee = addressee;
        _filter = filter;
    }

    public IAddressee Addressee { get; private set; }
    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            Addressee.Receive(message);
        }
    }
}