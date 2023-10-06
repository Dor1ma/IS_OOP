using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    public Meredian(bool isDeflectorPhoton)
    {
        Mass = ShipParameters.MediumMass;
        Deflector = new DeflectorClassTwo(isDeflectorPhoton);
        Armor = new ArmorClassTwo();
        AntiNitriniumEmitter = new AntiNitriniumEmitter();
        ImpulseEngine = new ImpulseEngineClassE();
    }
}