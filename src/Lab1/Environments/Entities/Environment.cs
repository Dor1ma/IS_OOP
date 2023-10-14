using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public ICollection<IObstacle> Obstacles { get; protected init; } = new List<IObstacle>();

    public int EnvironmentLength { get; protected init; }
    public Engine? Requirement { get; protected init; }
}