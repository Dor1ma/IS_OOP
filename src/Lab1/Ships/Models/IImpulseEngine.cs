namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IImpulseEngine
{
    public string ImpulseEngineType { get; }
    public string ImpulseEngineFuelType { get; protected init; }
    public int StartCost { get; }
    public double Speed { get; }
}