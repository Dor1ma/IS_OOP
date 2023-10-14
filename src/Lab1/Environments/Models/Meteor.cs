using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : ISpaceObstacle
{
    private const int MeteorDamage = 4;
    public int ObstacleDamage { get; init; } = MeteorDamage;
    public void DoDamage(Ship ship)
    {
        ship.DefenseMode(this);
    }
}