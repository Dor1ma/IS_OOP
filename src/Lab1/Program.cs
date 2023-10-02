using System;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1;

internal class Program
{
    public static void Main()
    {
        var ship = new Vaklas(true);
        Console.WriteLine(ship.DestroyedAsteroids);
        IArmor armor = new Shuttle(false);
        var armors = new IArmor[4];
        armors[0] = armor;
        Console.WriteLine(armors[0].MeteorsLimit);
    }
}