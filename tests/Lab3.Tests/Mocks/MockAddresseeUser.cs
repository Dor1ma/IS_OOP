using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockAddresseeUser : IAddressee
{
    private PriorityLevels _filter = PriorityLevels.None;
    public MockLogger Logger { get; private set; } = new();
    public IMessageEndPoint ConcreteAddressee { get; } = new User();

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            ConcreteAddressee.Save(message);
            Logger.LogInformation($"User received its message: {message.Body}");
        }
        else
        {
            Logger.LogInformation($"User didn't receive message: {message.Body}" +
                                   $"Reason: filter mismatch");
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}