using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    private readonly Collection<Obstacle> _obstacles = new(new List<Obstacle>());

    public Collection<Obstacle> Obstacles => _obstacles;
    public int EnvironmentLength { get; protected init; }
    public Type? Requirement { get; protected init; }
}