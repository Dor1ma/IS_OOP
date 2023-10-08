using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : IObstacle
{
    private const int WhaleDamage = 40;
    public int ObstacleDamage { get; init; } = WhaleDamage;
    public void DoDamage(Ship ship)
    {
        ship.DefenseMode(this);
    }
}