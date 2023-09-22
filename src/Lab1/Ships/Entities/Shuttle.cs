using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle(bool isPhoton)
        : base(0, 1, isPhoton)
    {
        ImpulseEngine = new ImpulseEngine('C');
        EngineTypes = "Impulse";
        Mass = 1.1;
    }
}