namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class JumpEngineOmega : IEngine
{
    public char EngineType { get; init; } = 'O';
    public string FuelType { get; init; } = "GravityMatter";
    public int Range { get; } = 500;
}