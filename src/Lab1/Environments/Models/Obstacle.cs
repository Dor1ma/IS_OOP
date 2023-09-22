using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public abstract class Obstacle
{
    public abstract void DoDamage(Ship ship);
}