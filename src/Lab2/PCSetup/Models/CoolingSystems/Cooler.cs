using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class Cooler : IPcComponent
{
    // Don't forget to implement the supportable processor list!
    public Cooler(string name, int height, int maximumTdp, ICollection<IProcessor> supportableSockets)
    {
        Name = name;
        Height = height;
        MaximumTdp = maximumTdp;
        SupportableSockets = supportableSockets;
    }

    public string Name { get; }
    public int Height { get; }
    public int MaximumTdp { get; }
    public ICollection<IProcessor> SupportableSockets { get; }
}