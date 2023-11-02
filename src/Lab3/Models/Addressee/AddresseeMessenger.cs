using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeMessenger : IAddressee
{
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public AddresseeMessenger(ILogger logger)
    {
        _logger = logger;
    }

    public IMessageEndPoint ConcreteAddressee { get; } = new Messenger();

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