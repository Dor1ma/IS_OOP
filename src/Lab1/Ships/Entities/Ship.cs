using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship
{
    public Deflector? Deflector { get; protected init; }
    public Armor? Armor { get; protected init; }
    public AntiNitriniumEmitter? AntiNitriniumEmitter { get; protected init; }
    public ImpulseEngine? ImpulseEngine { get; protected init; }
    public JumpEngine? JumpEngine { get; protected init; }
    public double Mass { get; protected init; }
    public double Cost { get; private set; }

    public bool IsBroken()
    {
        return Armor != null && (Armor.AsteroidsLimit <= 0 || Armor.MeteorsLimit <= 0);
    }

    public bool CrewStatus()
    {
        if (Deflector?.PhotonPart == null) return false;
        return Deflector.PhotonPart.ReflectedFlashes > 0;
    }

    public void UpdateCost(double computedPrice)
    {
        Cost += computedPrice;
    }
}
