namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public abstract class ImpulseEngine
{
    public int StartCost { get; protected init; }
    public double Speed { get; protected init; }
}