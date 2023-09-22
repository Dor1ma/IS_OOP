using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public Obstacle? FirstObstacle { get; set; }
    public Obstacle? SecondObstacle { get; set; }
    public int FirstObstaclesCount { get; set; }
    public int SecondObstaclesCount { get; set; }
    public string EngineRequired { get; set; } = "-";
    public string ExtraRequirenment { get; set; } = "-";
    public int EnvironmentLength { get; set; } = 100;
}
