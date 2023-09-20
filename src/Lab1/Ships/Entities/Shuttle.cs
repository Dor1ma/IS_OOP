using System;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('C');
    public Shuttle()
    {
        DeflectorClass = 0;
        AsteroidsLimit = 1;
        MeteorsLimit = 0;
        DestroyedAsteroids = 0;
        DestroyedMeteors = 0;
        ReflectedWhales = 0;
        IsActive = false;
    }

    public override void Defence()
    {
        Console.WriteLine(_impulseEngine.EngineType);
    }
}