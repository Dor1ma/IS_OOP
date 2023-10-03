using System;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1;

internal class Program
{
    public static void Main()
    {
        var ship = new Vaklas(true);
        IArmor armor = ship;
        IDeflector deflector = ship;
        Console.WriteLine(deflector.DestroyedAsteroids);
        Console.WriteLine(armor.AsteroidsLimit);
        deflector.DestroyedAsteroids--;
        armor.AsteroidsLimit--;
        Console.WriteLine(ship.DestroyedAsteroids);
        var armors = new IArmor[4];
        armors[0] = armor;
        Console.WriteLine(ship.AsteroidsLimit);
    }
}