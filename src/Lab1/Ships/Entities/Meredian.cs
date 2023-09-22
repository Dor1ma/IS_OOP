using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    public Meredian()
        : base(2, 2)
    {
        ImpulseEngine = new ImpulseEngine('E');
        EngineTypes = "Impulse";
        AntiNitriniumEmitter = true;
        Mass = 1.3;
    }
}