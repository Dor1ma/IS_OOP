namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class ImpulseEngine : Engine
{
    public ImpulseEngine()
    {
        FuelType = "Active Plasma";
    }

    public int StartCost { get; protected init; }
    public double Speed { get; protected init; }
}