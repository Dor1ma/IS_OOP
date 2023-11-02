using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeDisplay : IAddressee
{
    private readonly ILogger _logger;
    private PriorityLevels _filter = PriorityLevels.None;

    public AddresseeDisplay(ILogger logger)
    {
        _logger = logger;
    }

    public IMessageEndPoint Addressee { get; } = new Display();

    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
        {
            Addressee.Save(message);
            _logger.LogInformation($"Display received its message {message.Body}");
        }
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}