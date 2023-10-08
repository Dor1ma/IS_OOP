using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    public NitrinoParticleNebulae(IReadOnlyCollection<CosmoWhales> obstacles, int length)
    {
        EnvironmentLength = length;
        Requirement = typeof(ImpulseEngineClassE);
        foreach (CosmoWhales obstacle in obstacles)
        {
            Obstacles.Add(obstacle);
        }
    }
}