using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

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
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}