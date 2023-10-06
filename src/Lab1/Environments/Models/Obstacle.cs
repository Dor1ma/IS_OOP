using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public abstract class Obstacle
{
    public abstract void DoDamage(Deflector deflector, Armor armor);
}