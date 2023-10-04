using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship : IArmor, IDeflector, IImpulseEngine, IJumpEngine
{
    protected Ship(bool isPhoton)
    {
        EngineTypes = "None";
        AntiNitriniumEmitter = ShipParameters.NoAntiNitriniumEmitter;
        IsPhoton = isPhoton;
        IsActive = true;
        ImpulseEngineType = "-";
        ImpulseEngineFuelType = "ActivePlasma";
        JumpEngineType = "-";
        JumpEngineFuelType = "GravityMatter";
        if (isPhoton)
        {
            ReflectedFlashes = ShipParameters.PhotonDeflectorLimit;
        }
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
    public int ReflectedWhales { get; set; }
    public bool IsActive { get; set; }
    public bool IsPhoton { get; }
    public bool AntiNitriniumEmitter { get; protected init; }
    public double Cost { get; set; }
    public string ImpulseEngineType { get; init; }
    public string ImpulseEngineFuelType { get; init; }
    public int StartCost { get; init; }
    public string JumpEngineType { get; init; }
    public string JumpEngineFuelType { get; init; }
    public int Range { get; init; }
}
