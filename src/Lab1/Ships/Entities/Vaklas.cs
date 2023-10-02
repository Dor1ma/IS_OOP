using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    public Vaklas(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = 1.3;
        DeflectorClass = 1;
        DestroyedAsteroids = 2;
        DestroyedMeteors = 1;
        AsteroidsLimit = 5;
        MeteorsLimit = 2;
    }

    public ImpulseEngineE ImpulseEngineE { get; } = new ImpulseEngineE();
    public JumpEngineGamma JumpEngineGamma { get; } = new JumpEngineGamma();
}