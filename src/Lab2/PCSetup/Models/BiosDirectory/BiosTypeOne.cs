using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;

public class BiosTypeOne : Bios
{
    public BiosTypeOne(string name, int version, ICollection<Processor> supportableProcessor)
        : base(name, version, supportableProcessor)
    {
    }

    public override Bios Clone()
    {
        return new BiosTypeOne((string)Name.Clone(), Version, SupportableProcessors);
    }
}