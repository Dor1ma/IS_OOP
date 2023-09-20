using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Environments
{
    public Environments(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public virtual void Voice()
    {
        Console.WriteLine("I am an animal!");
    }
}
