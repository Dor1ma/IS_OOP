using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    public Space(IReadOnlyCollection<ISpaceObstacle> obstacles, int length)
    {
        foreach (ISpaceObstacle obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }

        Requirement = typeof(ImpulseEngine);
        EnvironmentLength = length;
    }
}