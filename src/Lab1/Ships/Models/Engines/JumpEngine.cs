using Itmo.ObjectOrientedProgramming.Lab1.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

public class JumpEngine : Engine
{
    public JumpEngine()
    {
        FuelType = new GravitonMatter();
    }

    public int Range { get; protected init; }
}