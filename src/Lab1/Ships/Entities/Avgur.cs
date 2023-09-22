using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    public Avgur()
        : base(3, 3)
    {
        ImpulseEngine = new ImpulseEngine('E');
        JumpEngine = new JumpEngine("Alpha");
        EngineTypes = "Both";
    }
}