using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public interface IObstacle
{
    public int ObstacleDamage { get; protected init; }
    public void DoDamage(Deflector deflector, Armor armor);
}