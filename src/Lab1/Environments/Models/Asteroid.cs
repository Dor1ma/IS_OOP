using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : IObstacle
{
    public void DoDamage(Ship ship)
    {
        if (ship != null)
        {
            if (ship.IsActive)
            {
                ship.DestroyedAsteroids--;
                if (ship.DestroyedAsteroids == 0)
                {
                    ship.IsActive = false;
                }
            } // DON'T FORGET TO IMPLEMENT ELSE CONDITIONS!!!
        }
    }
}