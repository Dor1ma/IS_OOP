using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : ISpaceObstacle
{
    private const int AsteroidDamage = 1;
    public int ObstacleDamage { get; init; } = AsteroidDamage;

    public void DoDamage(Ship ship)
    {
        ship.DefenseMode(this);
    }
}