using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Impulse";
        Mass = 1.1;
        DeflectorClass = 1;
        AsteroidsLimit = 1;
        MeteorsLimit = 0;
    }

    public ImpulseEngineC ImpulseEngineC { get; } = new ImpulseEngineC();
}