using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;

public class BiosTypeOne : IBios
{
    public BiosTypeOne(int version, IReadOnlyCollection<IProcessor> supportableProcessor)
    {
        Version = version;
        SupportableProcessor = supportableProcessor;
    }

    public int Version { get; }
    public IReadOnlyCollection<IProcessor> SupportableProcessor { get; }
}