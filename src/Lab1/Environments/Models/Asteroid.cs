using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : Obstacle
{
    public override void DoDamage(Ship ship)
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
            }
            else
            {
                ship.AsteroidsLimit--;
                if (ship.AsteroidsLimit == 0)
                {
                    ship.IsBroken = true;
                }
            }
        }
    }
}