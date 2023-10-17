namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class Cooller
{
    // Don't forget to implement the supportable processor list!
    public Cooller(string name, int height, int maximumTdp)
    {
        Name = name;
        Height = height;
        MaximumTdp = maximumTdp;
    }

    public string Name { get; private init; }
    public int Height { get; private init; }
    public int MaximumTdp { get; private init; }
}