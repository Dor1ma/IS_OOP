using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae(IReadOnlyCollection<AntimatterFlashes> obstacles, int length)
    {
        EnvironmentLength = length;
        Requirement = typeof(JumpEngine);
        foreach (AntimatterFlashes obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }
    }
}