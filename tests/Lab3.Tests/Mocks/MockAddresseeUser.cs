using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockAddresseeUser : IAddressee
{
    private PriorityLevels _filter = PriorityLevels.None;
    public MockLogger Logger { get; private set; } = new();
    public IUser ConcreteAddressee { get; } = new User();

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            ConcreteAddressee.Save(message);
            Logger.LogInformation(message);
        }
        else
        {
            Logger.LogInformation(message);
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}