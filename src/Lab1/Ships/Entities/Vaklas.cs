using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    public Vaklas(bool isDeflectorPhoton)
    {
        Mass = ShipParameters.MediumMass;
        Deflector = new DefectorClassOne(isDeflectorPhoton);
        Armor = new ArmorClassTwo();
        ImpulseEngine = new ImpulseEngineClassE();
        JumpEngine = new JumpEngineTypeGamma();
    }
}