using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    public NitrinoParticleNebulae(int cosmoWhalesCount, int length)
    {
        EnvironmentLength = length;
        Requirement = typeof(ImpulseEngineClassE);
        if (cosmoWhalesCount != 0)
        {
            for (int i = 0; i < cosmoWhalesCount; i++)
            {
                Obstacles.Add(new CosmoWhales());
            }
        }
    }
}