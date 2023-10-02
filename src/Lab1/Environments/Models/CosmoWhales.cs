using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : Obstacle, IWhale
{
    public override void DoDamage(IDeflector deflector, IArmor armor)
    {
        if (deflector.AntiNitriniumEmitter) return;
    }

    public void Attack(IAntiWhaleDeflector deflector, IArmor armor)
    {
        if (deflector.DeflectorClass == 3)
        {
            deflector.ReflectedWhales--;
            if (deflector.ReflectedFlashes == 0)
            {
                deflector.IsActive = false;
            }
        }
        else
        {
            armor.IsBroken = true;
        }
    }
}