namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IArmor
{
    int AsteroidsLimit { get; set; }
    int MeteorsLimit { get; set; }
    bool IsBroken { get; set; }
}