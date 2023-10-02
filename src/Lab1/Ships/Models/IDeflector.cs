namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IDeflector
{
    int DestroyedAsteroids { get; }
    int DestroyedMeteors { get; }
    int ReflectedFlashes { get; }
    bool IsActive { get; }
    bool IsPhoton { get; }
}