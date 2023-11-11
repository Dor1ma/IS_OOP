using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class TopicBuilder : ITopicBuilder
{
    private string _title = string.Empty;
    private IAddressee? _addressee;
    private Message? _message;

    public ITopicBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public ITopicBuilder WithAddressee(IAddressee addressee)
    {
        _addressee = addressee;
        return this;
    }

    public ITopicBuilder WithMessage(Message message)
    {
        _message = message;
        return this;
    }

    public Topic Build()
    {
        return new Topic(_title, _addressee, _message);
    }
}