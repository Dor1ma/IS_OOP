namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IJumpEngine
{
    public string JumpEngineType { get; protected init; }
    public string JumpEngineFuelType { get; protected init; }
    public int Range { get; init; }
}