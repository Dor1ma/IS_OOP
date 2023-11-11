using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class LoggerDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;

    public LoggerDecorator(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void Receive(Message message)
    {
        _addressee.Receive(message);
        _logger.LogInformation(message);
    }
}