using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    public NitrinoParticleNebulae(int cosmoWhalesCount, int length)
    {
        FirstObstacle = new CosmoWhales();
        EngineRequired = "Impulse";
        ExtraRequirenment = "E";
        FirstObstaclesCount = cosmoWhalesCount;
        EnvironmentLength = length;
    }
}