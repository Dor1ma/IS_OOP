namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IEngine
{
    char EngineType { get; protected init; }
    string FuelType { get; protected init; }
}