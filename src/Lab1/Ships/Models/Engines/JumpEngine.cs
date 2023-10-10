namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class JumpEngine : Engine
{
    public JumpEngine()
    {
        FuelType = "Graviton Matter";
    }

    public int Range { get; protected init; }
}