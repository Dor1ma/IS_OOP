using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory.Factories;

public class BiosTypeOneFactory : IBiosFactory
{
    public IBios Create(int version, IReadOnlyCollection<IProcessor> supportableProcessor)
    {
        return new BiosTypeOne(version, supportableProcessor);
    }
}