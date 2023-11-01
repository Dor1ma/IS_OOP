namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public interface IAddressee
{
    void Receive(Message message);
    void SetupFilter(PriorityLevels priorityLevel);
}