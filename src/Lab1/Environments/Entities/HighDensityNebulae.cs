using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae(IReadOnlyCollection<IObstacle> obstacles, int length)
    {
        EnvironmentLength = length;
        Requirement = typeof(JumpEngine);
        foreach (IObstacle obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }
    }
}