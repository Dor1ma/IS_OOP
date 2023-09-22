using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    public Stella()
        : base(1, 1)
    {
        ImpulseEngine = new ImpulseEngine('C');
        JumpEngine = new JumpEngine("Omega");
        EngineTypes = "Both";
    }
}