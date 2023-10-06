using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    public Stella(bool isDeflectorPhoton)
    {
        Mass = ShipParameters.LowMass;
        Deflector = new DefectorClassOne(isDeflectorPhoton);
        Armor = new ArmorClassOne();
        ImpulseEngine = new ImpulseEngineClassC();
        JumpEngine = new JumpEngineTypeOmega();
    }
}