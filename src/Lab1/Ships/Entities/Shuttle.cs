using System;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Shuttle : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('C');
    public Shuttle()
        : base(0, 1) { }

    public void Temp()
    {
        Console.WriteLine(_impulseEngine.EngineType);
    }
}