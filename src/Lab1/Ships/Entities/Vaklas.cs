using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    public Vaklas()
        : base(1, 2)
    {
        ImpulseEngine = new ImpulseEngine('E');
        JumpEngine = new JumpEngine("Gamma");
        EngineTypes = "Both";
    }

    public bool Active { get; set; } = true;
}