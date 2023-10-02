using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : Obstacle
{
    public override void DoDamage(Ship ship)
    {
        if (ship.IsActive)
        {
            ship.DestroyedMeteors--;
            if (ship.DestroyedMeteors == 0)
            {
                ship.IsActive = false;
            }
        }
        else
        {
            ship.MeteorsLimit--;
            if (ship.MeteorsLimit == 0)
            {
                ship.IsBroken = true;
            }
        }
    }
}