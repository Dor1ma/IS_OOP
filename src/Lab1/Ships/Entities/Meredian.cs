namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    public Meredian(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Impulse";
        AntiNitriniumEmitter = true;
        Mass = 1.3;
        DeflectorClass = 2;
        DestroyedAsteroids = 10;
        DestroyedMeteors = 3;
        AsteroidsLimit = 5;
        MeteorsLimit = 2;
        ImpulseEngineType = "E";
        StartCost = 25;
    }
}