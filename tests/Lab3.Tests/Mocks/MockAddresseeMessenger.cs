using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockAddresseeMessenger : IAddressee
{
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public MockAddresseeMessenger(ILogger logger)
    {
        _logger = logger;
    }

    public IMessageEndPoint ConcreteAddressee { get; } = new MockMessenger();

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            ConcreteAddressee.Save(message);
            _logger.LogInformation($"Messenger received its message: {message.Body}");
        }
        else
        {
            _logger.LogInformation($"Messenger didn't receive message: {message.Body}" +
                                   $"Reason: filter mismatch");
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}