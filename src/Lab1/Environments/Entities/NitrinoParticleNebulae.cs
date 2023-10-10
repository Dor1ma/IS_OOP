using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    public NitrinoParticleNebulae(IReadOnlyCollection<INitrinoParticleNebulaeObstacle> obstacles, int length)
    {
        EnvironmentLength = length;
        Requirement = new ImpulseEngineClassE();
        foreach (INitrinoParticleNebulaeObstacle obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }
    }
}