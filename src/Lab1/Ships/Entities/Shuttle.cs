using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    public Shuttle()
    {
        Mass = ShipParameters.LowMass;
        Armor = new ArmorClassOne();
        ImpulseEngine = new ImpulseEngineClassC();
    }
}