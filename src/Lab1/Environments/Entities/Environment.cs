using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    private readonly ReadOnlyCollection<IObstacle> _obstacles = new(new List<IObstacle>());

    public ICollection<IObstacle> Obstacles => _obstacles;
    public int EnvironmentLength { get; protected init; }
    public Type? Requirement { get; protected init; }
}