using Itmo.ObjectOrientedProgramming.Lab1.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class ImpulseEngine : Engine
{
    public ImpulseEngine()
    {
        FuelType = new ActivePlasma();
    }

    public int StartCost { get; protected init; }
    public double Speed { get; protected init; }
}