using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle()
        : base(0, 1)
    {
        ImpulseEngine = new ImpulseEngine('C');
        EngineTypes = "Impulse";
    }
}