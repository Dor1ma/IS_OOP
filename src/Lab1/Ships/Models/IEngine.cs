namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IEngine
{
    char EngineType { get; set; }
    string FuelType { get; set; }
    int FuelConsumption { get; set; }
}