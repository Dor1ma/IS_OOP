using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : IObstacle
{
    private const int FlashDamage = 1;
    public int ObstacleDamage { get; init; } = FlashDamage;
    public void DoDamage(Ship ship)
    {
        ship.DefenseMode(this);
    }
}