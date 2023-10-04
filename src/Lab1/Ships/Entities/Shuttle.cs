namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Impulse";
        Mass = 1.1;
        IsActive = false;
        AsteroidsLimit = 1;
        MeteorsLimit = 0;
        ImpulseEngineType = "C";
        StartCost = 10;
    }
}