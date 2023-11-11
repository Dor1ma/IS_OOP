using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class MockDecoratedLogger : IAddressee
{
    private readonly IAddressee _addressee;

    public MockDecoratedLogger(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        Logger = logger;
    }

    public ILogger Logger { get; private set; }

    public void Receive(Message message)
    {
        _addressee.Receive(message);
        Logger.LogInformation(message);
    }
}