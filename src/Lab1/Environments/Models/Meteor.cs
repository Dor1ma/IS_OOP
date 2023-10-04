using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : Obstacle
{
    public override void DoDamage(IDeflector deflector, IArmor armor)
    {
        if (deflector.IsActive)
        {
            deflector.DestroyedMeteors--;
            if (deflector.DestroyedMeteors <= 0)
            {
                deflector.IsActive = false;
            }
        }
        else
        {
            armor.MeteorsLimit--;
            if (armor.MeteorsLimit <= 0)
            {
                armor.IsBroken = true;
            }
        }
    }
}