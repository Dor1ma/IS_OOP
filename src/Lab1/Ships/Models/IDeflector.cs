namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IDeflector
{
    int DeflectorClass { get; }
    int DestroyedAsteroids { get; set; }
    int DestroyedMeteors { get; set; }
    int ReflectedFlashes { get; set; }
    int ReflectedWhales { get; set; }
    bool IsActive { get; set; }
    bool IsPhoton { get; }
    bool AntiNitriniumEmitter { get; }
}