namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IDeflector
{
    int DestroyedAsteroids { get; set; }
    int DestroyedMeteors { get; set; }
    int ReflectedWhales { get; set; }
    bool IsActive { get; set; }
    void Defence();
}