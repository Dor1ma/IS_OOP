using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    public Space(ICollection<IObstacle> obstacles, int length)
    {
        Obstacles = obstacles;

        Requirement = new ImpulseEngine();
        EnvironmentLength = length;
    }
}