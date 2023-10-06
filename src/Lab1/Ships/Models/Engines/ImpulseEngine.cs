namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public abstract class ImpulseEngine
{
    public int StartCost { get; protected set; }
    public double Speed { get; protected set; }
}