using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public Obstacle? FirstObstacle { get; protected init; }
    public Obstacle? SecondObstacle { get; protected init; }
    public int FirstObstaclesCount { get; protected init; }
    public int SecondObstaclesCount { get; protected init; }
    public string EngineRequired { get; protected init; } = "-";
    public string ExtraRequirenment { get; protected init; } = "-";
    public int EnvironmentLength { get; protected init; }
}