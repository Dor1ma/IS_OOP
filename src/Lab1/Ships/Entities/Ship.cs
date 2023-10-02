using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship : IArmor, IDeflector
{
    protected Ship(bool isPhoton)
    {
        EngineTypes = "None";
        CrewStatus = true;
        AntiNitriniumEmitter = false;
        IsPhoton = isPhoton;
        IsActive = true;
    }

    public double Mass { get; protected init; }
    public string EngineTypes { get; protected init; }
    public int AsteroidsLimit { get; protected set; }
    public int MeteorsLimit { get; protected set; }
    public bool IsBroken { get; protected set; }
    public int DestroyedAsteroids { get; protected set; }
    public int DestroyedMeteors { get; protected set; }
    public int ReflectedFlashes { get; protected set; }
    public bool IsActive { get; protected set; }
    public bool IsPhoton { get; }
    public bool CrewStatus { get; protected set; }
    public bool AntiNitriniumEmitter { get; protected init; }
    public double Cost { get; set; }
}
