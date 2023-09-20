using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship : IArmor, IDeflector
{
    public int AsteroidsLimit { get; set; }
    public int MeteorsLimit { get; set; }
    public bool IsBroken { get; set; }
    public int DeflectorClass { get; set; }
    public int DestroyedAsteroids { get; set; }
    public int DestroyedMeteors { get; set; }
    public int ReflectedWhales { get; set; }
    public int ReflectedFlashes { get; set; }
    public bool IsActive { get; set; }
    public bool IsPhoton { get; set; }
    public abstract void Defence();

    public virtual void Go() { }
}
