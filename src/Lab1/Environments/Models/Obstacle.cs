using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public abstract class Obstacle
{
    public abstract void DoDamage(IDeflector deflector, IArmor armor);
}