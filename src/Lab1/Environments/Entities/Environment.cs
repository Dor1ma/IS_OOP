namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public abstract class Environment
{
    public string EngineRequired { get; set; } = "-";
    public string ExtraRequirenment { get; set; } = "-";
    public int EnvironmentLength { get; set; } = 100;
}
