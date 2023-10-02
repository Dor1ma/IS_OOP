namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class ImpulseEngineC : IEngine
{
    public char EngineType { get; init; } = 'C';
    public string FuelType { get; init; } = "ActivePlasma";
    public int StartCost { get; set; } = 10;
}