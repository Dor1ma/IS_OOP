using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : Obstacle
{
    public override void DoDamage(IDeflector deflector, IArmor armor)
    {
        if (deflector.IsActive)
        {
            deflector.DestroyedAsteroids--;
            if (deflector.DestroyedAsteroids <= 0)
            {
                deflector.IsActive = false;
            }
        }
        else
        {
            armor.AsteroidsLimit--;
            if (armor.AsteroidsLimit <= 0)
            {
                armor.IsBroken = true;
            }
        }
    }
}