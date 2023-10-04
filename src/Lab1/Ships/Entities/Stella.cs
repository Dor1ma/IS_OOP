namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    public Stella(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Both";
        Mass = ShipParameters.LowMass;
        DeflectorClass = 1;
        DestroyedAsteroids = ShipParameters.FirstDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.FirstDeflectorsMeteorsLimit;
        AsteroidsLimit = ShipParameters.ArmorClassOneAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassOneMeteorsLimit;
        ImpulseEngineType = "C";
        Speed = ShipParameters.ImpulseEngineTypeCSpeed;
        StartCost = ShipParameters.ImpulseEngineTypeCStartCost;
        JumpEngineType = "Omega";
        Range = ShipParameters.JumpEngineTypeOmegaRange;
    }
}