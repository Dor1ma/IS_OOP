namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IArmor
{
    int AsteroidsLimit { get; }
    int MeteorsLimit { get; }
    bool IsBroken { get; }
}