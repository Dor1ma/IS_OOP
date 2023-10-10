using Itmo.ObjectOrientedProgramming.Lab1.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public abstract class Engine
{
    public Fuel? FuelType { get; protected init; }
}