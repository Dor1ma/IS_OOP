using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory.Factories;

public class BiosTypeTwoFactory : IBiosFactory
{
    public IBios Create(int version, IReadOnlyCollection<IProcessor> supportableProcessor)
    {
        return new BiosTypeTwo(version, supportableProcessor);
    }
}