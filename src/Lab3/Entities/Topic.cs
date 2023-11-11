using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class Topic
{
    public Topic(string title, IAddressee? addressee, Message? message)
    {
        Title = title;
        Addressee = addressee;
        Message = message;
    }

    public string Title { get; private set; }
    public IAddressee? Addressee { get; private set; }
    public Message? Message { get; private set; }

    public void GetNewMessage(Message message)
    {
        Message = message;
    }

    public void SendMessageToAddressee()
    {
        if (Message is not null) Addressee?.Receive(Message);
    }
}