using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public Collection<IObstacle> Obstacles { get; } = new(new List<IObstacle>());

    public int EnvironmentLength { get; protected init; }
    public Type? Requirement { get; protected init; }
}