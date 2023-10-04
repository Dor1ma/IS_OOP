namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    public Avgur(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = ShipParameters.HighMass;
        DeflectorClass = 3;
        DestroyedAsteroids = ShipParameters.ThirdDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.ThirdDeflectorsMeteorsLimit;
        ReflectedWhales = ShipParameters.ThirdDeflectorsWhalesLimit;
        AsteroidsLimit = ShipParameters.ArmorClassThreeAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassThreeMeteorsLimit;
        ImpulseEngineType = "E";
        StartCost = ShipParameters.ImpulseEngineTypeEStartCost;
        JumpEngineType = "Alpha";
        Range = ShipParameters.JumpEngineTypeAlphaRange;
    }
}