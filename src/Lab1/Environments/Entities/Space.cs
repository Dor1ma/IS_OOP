using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    private Asteroid _asteroid = new Asteroid();
    private Meteor _meteor = new Meteor();
    public Space(int asteroids, int meteors)
    {
        EngineRequired = "Impulse";
        AsteroidsCount = asteroids;
        MeteorsCount = meteors;
    }

    private int AsteroidsCount { get; set; }
    private int MeteorsCount { get; set; }

    public void Temp()
    {
        Console.WriteLine(_asteroid);
        Console.WriteLine(_meteor);
    }
}