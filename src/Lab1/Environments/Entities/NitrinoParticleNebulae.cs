using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    public NitrinoParticleNebulae(ICollection<IObstacle> obstacles, int length)
    {
        Obstacles = obstacles;
        EnvironmentLength = length;
        Requirement = new ImpulseEngineClassE();
    }
}