namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class ImpulseEngineClassC : ImpulseEngine
{
    private const int ImpulseEngineTypeCStartCost = 10;
    private const int ImpulseEngineTypeCSpeed = 150;
    public ImpulseEngineClassC()
    {
        StartCost = ImpulseEngineTypeCStartCost;
        Speed = ImpulseEngineTypeCSpeed;
    }
}