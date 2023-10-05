namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IImpulseEngine
{
    public string ImpulseEngineType { get; }
    public int StartCost { get; }
    public double Speed { get; }
}