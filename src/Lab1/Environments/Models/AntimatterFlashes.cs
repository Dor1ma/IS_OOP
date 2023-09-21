using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : IObstacle
{
    public void DoDamage(Ship ship)
    {
        if (ship != null)
        {
            if (ship.IsPhoton)
            {
                ship.ReflectedFlashes--;
                if (ship.ReflectedFlashes == 0)
                {
                    ship.IsActive = false;
                }
            } // DON'T FORGET TO IMPLEMENT ELSE CONDTIONS!!!
        }
    }
}