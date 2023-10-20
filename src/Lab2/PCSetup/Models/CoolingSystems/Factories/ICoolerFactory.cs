using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public interface ICoolerFactory
{
    Cooler Create(string name, int height, int maximumTdp, ICollection<Processor> supportableSockets, int powerConsumption);
}