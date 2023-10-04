using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : Obstacle
{
    public override void DoDamage(IDeflector deflector, IArmor armor)
    {
        if (deflector.IsPhoton)
        {
            deflector.ReflectedFlashes--;
            if (deflector.ReflectedFlashes <= 0)
            {
                deflector.IsActive = false;
            }
        }
    }
}