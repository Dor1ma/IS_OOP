namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IDeflector
{
    int DeflectorClass { get; set; }
    int DestroyedAsteroids { get; set; }
    int DestroyedMeteors { get; set; }
    int ReflectedFlashes { get; set; }
    bool IsActive { get; set; }
    bool IsPhoton { get; }
    bool AntiNitriniumEmitter { get; protected init; }
}