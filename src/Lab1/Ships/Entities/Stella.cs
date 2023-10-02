using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    public Stella(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = 1.1;
        DeflectorClass = 1;
        DestroyedAsteroids = 2;
        DestroyedMeteors = 1;
        AsteroidsLimit = 1;
        MeteorsLimit = 0;
    }

    public ImpulseEngineC ImpulseEngineC { get; } = new ImpulseEngineC();
    public JumpEngineOmega JumpEngineOmega { get; } = new JumpEngineOmega();
}