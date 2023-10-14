namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class ImpulseEngineClassE : ImpulseEngine
{
    private const int ImpulseEngineTypeEStartCost = 25;
    public ImpulseEngineClassE()
    {
        StartCost = ImpulseEngineTypeEStartCost;
    }
}