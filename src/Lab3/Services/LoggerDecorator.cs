using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class LoggerDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;

    public LoggerDecorator(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        ConcreteAddressee = addressee.ConcreteAddressee;
        _logger = logger;
    }

    public IMessageEndPoint ConcreteAddressee { get; }
    public void Receive(Message message)
    {
        _addressee.Receive(message);
    }
}