using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;

public class AddresseeUser : IAddressee
{
    private PriorityLevels _filter = PriorityLevels.None;
    public User User { get; private set; } = new User();
    public void Receive(Message message)
    {
        if (_filter == PriorityLevels.None || message.PriorityLevel == _filter)
            User.Save(message);
    }

    public void SetupFilter(PriorityLevels priorityLevel)
    {
        _filter = priorityLevel;
    }
}