using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : Obstacle
{
    public override void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector.DestroyedAsteroids > 0)
        {
            deflector.DestroyAsteroid();
            return;
        }

        if (armor.AsteroidsLimit > 0)
        {
            armor.DefendFromMeteor();
        }
    }
}