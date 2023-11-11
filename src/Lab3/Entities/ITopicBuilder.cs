using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public interface ITopicBuilder
{
    ITopicBuilder WithTitle(string title);
    ITopicBuilder WithAddressee(IAddressee addressee);
    ITopicBuilder WithMessage(Message message);
    Topic Build();
}