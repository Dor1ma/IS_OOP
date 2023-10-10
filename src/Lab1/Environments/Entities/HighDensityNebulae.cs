using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae(IReadOnlyCollection<IHighDensityNebulaeObstacle> obstacles, int length)
    {
        EnvironmentLength = length;
        Requirement = new JumpEngine();
        foreach (IHighDensityNebulaeObstacle obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }
    }
}