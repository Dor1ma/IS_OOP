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
        ImpulseEngineType = "E";
        StartCost = 25;
        JumpEngineType = "Gamma";
        Range = 1000;
    }
}