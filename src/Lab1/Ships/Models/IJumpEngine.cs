namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IJumpEngine
{
    public string JumpEngineType { get; }
    public int Range { get; }
}