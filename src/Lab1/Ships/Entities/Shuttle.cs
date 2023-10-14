using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    private const double LowMass = 1.1;
    public Shuttle()
    {
        Mass = LowMass;
        Armor = new ArmorClassOne();
        ImpulseEngine = new ImpulseEngineClassC();
    }
}