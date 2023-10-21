using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory.Factories;

public class BiosTypeOneFactory : IBiosFactory
{
    public Bios Create(string name, int version, ICollection<Processor> supportableProcessor)
    {
        return new BiosTypeOne(name, version, supportableProcessor);
    }
}