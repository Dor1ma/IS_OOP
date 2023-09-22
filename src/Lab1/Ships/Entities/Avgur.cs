using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    public Avgur(bool isPhoton)
        : base(3, 3, isPhoton)
    {
        ImpulseEngine = new ImpulseEngine('E');
        JumpEngine = new JumpEngine("Alpha");
        EngineTypes = "Both";
        Mass = 1.5;
    }
}