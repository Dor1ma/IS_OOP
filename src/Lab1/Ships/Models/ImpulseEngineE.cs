namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class ImpulseEngineE : IEngine
{
    public char EngineType { get; init; } = 'E';
    public string FuelType { get; init; } = "ActivePlasma";
    public int StartCost { get; set; } = 25;
}