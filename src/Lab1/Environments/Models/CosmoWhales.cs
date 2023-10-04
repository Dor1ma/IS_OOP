using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : Obstacle
{
    public override void DoDamage(IDeflector deflector, IArmor armor)
    {
        if (deflector.AntiNitriniumEmitter) return;
        if (deflector.DeflectorClass == 3)
        {
            deflector.ReflectedWhales--;
            if (deflector.ReflectedWhales == 0)
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