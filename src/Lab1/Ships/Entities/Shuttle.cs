namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Impulse";
        Mass = ShipParameters.LowMass;
        IsActive = false;
        AsteroidsLimit = ShipParameters.ArmorClassOneAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassOneMeteorsLimit;
        ImpulseEngineType = "C";
        Speed = ShipParameters.ImpulseEngineTypeCSpeed;
        StartCost = ShipParameters.ImpulseEngineTypeCStartCost;
    }
}