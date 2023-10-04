namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    public Vaklas(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = ShipParameters.MediumMass;
        DeflectorClass = 1;
        DestroyedAsteroids = ShipParameters.FirstDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.FirstDeflectorsMeteorsLimit;
        AsteroidsLimit = ShipParameters.ArmorClassTwoAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassTwoMeteorsLimit;
        ImpulseEngineType = "E";
        StartCost = ShipParameters.ImpulseEngineTypeEStartCost;
        JumpEngineType = "Gamma";
        Range = ShipParameters.JumpEngineTypeGammaRange;
    }
}