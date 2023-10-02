using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public interface IWhale
{
    void Attack(IAntiWhaleDeflector deflector, IArmor armor);
}