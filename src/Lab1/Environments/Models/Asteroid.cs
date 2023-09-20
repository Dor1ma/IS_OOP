using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : IObstacle
{
    public void DoDamage(IDeflector deflector)
    {
        if (deflector != null)
        {
            if (deflector.IsActive)
            {
                deflector.DestroyedAsteroids--;
                if (deflector.DestroyedAsteroids == 0)
                {
                    deflector.IsActive = false;
                }
            } // DON'T FORGET TO IMPLEMENT ELSE CONDITIONS!!!
        }
    }
}