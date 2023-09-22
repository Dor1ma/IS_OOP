using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    public Stella(bool isPhoton)
        : base(1, 1, isPhoton)
    {
        ImpulseEngine = new ImpulseEngine('C');
        JumpEngine = new JumpEngine("Omega");
        EngineTypes = "Both";
        Mass = 1.1;
    }
}