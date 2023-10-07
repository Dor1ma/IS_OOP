using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : IObstacle
{
    public void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector.DestroyedAsteroids > 0)
        {
            deflector.DestroyAsteroid();
            return;
        }

        if (armor.AsteroidsLimit > 0)
        {
            armor.DefendFromAsteroid();
        }
    }
}