using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    private readonly Asteroid _asteroid = new Asteroid();
    private readonly Meteor _meteor = new Meteor();
    public Space(int asteroids, int meteors, int length)
    {
        EngineRequired = "Impulse";
        AsteroidsCount = asteroids;
        MeteorsCount = meteors;
        EnvironmentLength = length;
    }

    private int AsteroidsCount { get; set; }
    private int MeteorsCount { get; set; }

    public void Temp()
    {
        Console.WriteLine(_asteroid);
        Console.WriteLine(_meteor);
    }
}