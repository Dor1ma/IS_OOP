using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    public Avgur(bool isDeflectorPhoton)
    {
        Mass = ShipParameters.HighMass;
        Deflector = new DeflectorClassThree(isDeflectorPhoton);
        Armor = new ArmorClassThree();
        ImpulseEngine = new ImpulseEngineClassE();
        JumpEngine = new JumpEngineTypeAlpha();
    }
}