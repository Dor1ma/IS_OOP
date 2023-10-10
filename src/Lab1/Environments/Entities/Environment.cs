using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public ICollection<IObstacle> Obstacles { get; } = new List<IObstacle>();

    public int EnvironmentLength { get; protected init; }
    public Type? Requirement { get; protected init; }
}