using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : IObstacle
{
    private const int WhaleDamage = 40;
    public int ObstacleDamage { get; init; } = WhaleDamage;
    public void DoDamage(Deflector deflector, Armor armor)
    {
        deflector.TakeDamage(ObstacleDamage);
    }
}