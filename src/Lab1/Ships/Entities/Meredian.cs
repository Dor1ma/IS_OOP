namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    public Meredian(bool isPhoton)
        : base(isPhoton)
    {
        EngineTypes = "Impulse";
        AntiNitriniumEmitter = ShipParameters.WithAntiNitriniumEmitter;
        Mass = ShipParameters.MediumMass;
        DeflectorClass = 2;
        DestroyedAsteroids = ShipParameters.SecondDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.SecondDeflectorsMeteorsLimit;
        AsteroidsLimit = ShipParameters.ArmorClassTwoAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassTwoMeteorsLimit;
        ImpulseEngineType = "E";
        StartCost = ShipParameters.ImpulseEngineTypeEStartCost;
    }
}