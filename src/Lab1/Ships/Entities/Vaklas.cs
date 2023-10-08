using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    private const double MediumMass = 1.3;
    public Vaklas(bool isDeflectorPhoton)
    {
        Mass = MediumMass;
        Deflector = new DefectorClassOne(isDeflectorPhoton);
        Armor = new ArmorClassTwo();
        ImpulseEngine = new ImpulseEngineClassE();
        JumpEngine = new JumpEngineTypeGamma();
    }
}