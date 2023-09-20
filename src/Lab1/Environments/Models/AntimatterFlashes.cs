using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : IObstacle
{
    public void DoDamage(IDeflector deflector)
    {
        if (deflector != null)
        {
            if (deflector.IsPhoton)
            {
                deflector.ReflectedFlashes--;
                if (deflector.ReflectedFlashes == 0)
                {
                    deflector.IsActive = false;
                }
            } // DON'T FORGET TO IMPLEMENT ELSE CONDTIONS!!!
        }
    }
}