namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IImpulseEngine
{
    public string ImpulseEngineType { get; protected init; }
    public string ImpulseEngineFuelType { get; protected init; }
    public int StartCost { get; init; }
}