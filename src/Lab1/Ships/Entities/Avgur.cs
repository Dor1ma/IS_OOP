namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    public Avgur(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = 1.5;
        DeflectorClass = 3;
        DestroyedAsteroids = 40;
        DestroyedMeteors = 10;
        ReflectedWhales = 1;
        AsteroidsLimit = 20;
        MeteorsLimit = 5;
        ImpulseEngineType = "E";
        StartCost = 25;
        JumpEngineType = "Alpha";
        Range = 100;
    }
}