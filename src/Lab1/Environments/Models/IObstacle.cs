using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public interface IObstacle
{
    public int ObstacleDamage { get; protected init; }
    public void DoDamage(Ship ship);
}