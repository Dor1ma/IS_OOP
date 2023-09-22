using System;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1;

internal class Program
{
    public static void Main()
    {
        var ship = new Vaklas(true);
        Console.WriteLine(ship.DestroyedAsteroids);
    }
}
