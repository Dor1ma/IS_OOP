using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeMessenger : IAddressee
{
    private readonly Messenger _messenger = new Messenger();
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public AddresseeMessenger(ILogger logger)
    {
        _logger = logger;
    }

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            _messenger.Save(message);
            _logger.LogInformation($"Messenger received its message: {message.Body}");
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}