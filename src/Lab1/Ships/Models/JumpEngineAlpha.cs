namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class JumpEngineAlpha : IEngine
{
    public char EngineType { get; init; } = 'A';
    public string FuelType { get; init; } = "GravityMatter";
    public int Range { get; } = 100;
}