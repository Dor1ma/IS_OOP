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
    public int DeflectorClass { get; set; }
    public int AsteroidsLimit { get; set; }
    public int MeteorsLimit { get; set; }
    public bool IsBroken { get; set; }
    public int DestroyedAsteroids { get; set; }
    public int DestroyedMeteors { get; set; }
    public int ReflectedFlashes { get; set; }
    public bool IsActive { get; set; }
    public bool IsPhoton { get; }
    public bool CrewStatus { get; protected set; }
    public bool AntiNitriniumEmitter { get; init; }
    public double Cost { get; set; }
}
