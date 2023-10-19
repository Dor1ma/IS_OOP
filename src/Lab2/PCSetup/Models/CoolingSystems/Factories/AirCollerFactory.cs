using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public class AirCollerFactory : ICollerFactory
{
    public Cooler Create(string name, int height, int maximumTdp, ICollection<Processor> supportableSockets)
    {
        return new Cooler(name, height, maximumTdp, supportableSockets);
    }
}