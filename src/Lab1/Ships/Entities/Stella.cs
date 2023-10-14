using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    private const double LowMass = 1.1;
    public Stella(bool isDeflectorPhoton)
    {
        Mass = LowMass;
        Deflector = new DefectorClassOne(isDeflectorPhoton);
        Armor = new ArmorClassOne();
        ImpulseEngine = new ImpulseEngineClassC();
        JumpEngine = new JumpEngineTypeOmega();
    }
}