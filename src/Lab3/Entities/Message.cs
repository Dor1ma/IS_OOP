using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class Message
{
    public Message(string header, string body, PriorityLevels priorityLevel)
    {
        Header = header;
        Body = body;
        PriorityLevel = priorityLevel;
    }

    public string Header { get; private set; }
    public string Body { get; private set; }
    public Status? Status { get; private set; }
    public PriorityLevels PriorityLevel { get; private set; }

    public void MarkAsUnread()
    {
        Status = Models.Status.Unread;
    }

    public void MarkAsRead()
    {
        Status = Models.Status.Read;
    }
}