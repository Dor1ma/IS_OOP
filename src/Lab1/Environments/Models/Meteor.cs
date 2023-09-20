using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : IObstacle
{
    public void DoDamage(IDeflector deflector)
    {
        if (deflector != null)
        {
            if (deflector.IsActive)
            {
                deflector.DestroyedMeteors--;
                if (deflector.DestroyedMeteors == 0)
                {
                    deflector.IsActive = false;
                }
            } // DON'T FORGET TO IMPLEMENT ELSE CONDITIONS!!!
        }
    }
}