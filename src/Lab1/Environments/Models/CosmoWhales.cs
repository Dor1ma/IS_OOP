using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : Obstacle
{
    public override void DoDamage(Ship ship)
    {
        if (ship != null)
        {
            if (!ship.AntiNitriniumEmitter)
            {
                if (ship.DeflectorClass == 3)
                {
                    ship.ReflectedWhales--;
                    if (ship.ReflectedFlashes == 0)
                    {
                        ship.IsActive = false;
                    }
                }
                else
                {
                    ship.IsBroken = true;
                }
            }
        }
    }
}