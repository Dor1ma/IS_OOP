using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : IObstacle
{
    public void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector.DestroyedMeteors > 0)
        {
            deflector.DestroyMeteor();
            return;
        }

        if (armor.MeteorsLimit > 0)
        {
            armor.DefendFromMeteor();
        }
    }
}