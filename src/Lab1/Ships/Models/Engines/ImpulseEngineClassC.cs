namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class ImpulseEngineClassC : ImpulseEngine
{
    public ImpulseEngineClassC()
    {
        StartCost = ShipParameters.ImpulseEngineTypeCStartCost;
        Speed = ShipParameters.ImpulseEngineTypeCSpeed;
    }
}